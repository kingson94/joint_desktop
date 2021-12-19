using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using Service;

namespace Core
{
    public class Engine : Component
    {
        private Queue<Task> m_queTaskQueue;
        private List<Worker> m_lstWorker;
        private Dictionary<int, BaseService> m_hmService;

        private System.Threading.Mutex m_mtxQueueRead;
        private System.Threading.Mutex m_mtxQueueWrite;
        private System.Threading.ManualResetEvent m_evtEmptyCondition;
        private System.Threading.ManualResetEvent m_evtFullCondition;

        private int m_iWorkerCount;
        private int m_iQueueMaxSize;
        private int m_iQueueCurrentSize;
        public Engine() : base(Global.ENGINE_COMP)
        {
            m_queTaskQueue = null;
            m_iWorkerCount = 0;
            m_iQueueMaxSize = 0;
            m_iQueueCurrentSize = 0;

            m_lstWorker = new List<Worker>();
            m_hmService = new Dictionary<int, BaseService>();
            m_mtxQueueRead = new System.Threading.Mutex();
            m_mtxQueueWrite = new System.Threading.Mutex();

            m_evtEmptyCondition = new System.Threading.ManualResetEvent(false);
            m_evtFullCondition = new System.Threading.ManualResetEvent(false);
        }

        ~Engine()
        {
            m_evtEmptyCondition.Dispose();
            m_evtFullCondition.Dispose();
            m_mtxQueueRead.Dispose();
            m_mtxQueueWrite.Dispose();
        }

        public override void Join()
        {
            // Do nothing
        }

        public override void Init()
        {
            base.Init();
            JObject jConfig = null;

            if (Util.JsonFromFile(Global.ENGINE_CONFIG, ref jConfig) == 0)
            {
                m_iWorkerCount = (int) jConfig["worker_count"];
                m_iQueueMaxSize = (int) jConfig["queue_capacity"];
            }

            m_queTaskQueue = new Queue<Task>(m_iQueueMaxSize);

            // Init worker
            for (int i = 0; i < m_iWorkerCount; i++)
            {
                Worker obWorker = new Worker(i);
                m_lstWorker.Add(obWorker);
            }
        }

        public void RegisterService(BaseService obService)
        {
            if (obService != null)
            {
                m_hmService[obService.GetID()] = obService;
            }
        }

        public override void Run()
        {
            if (m_bIsInit)
            {
                foreach (Worker obWorker in m_lstWorker)
                {
                    obWorker.Start();
                }
            }
        }

        public void ConsumeTask()
        {
            // Get task
            Task obTask = GetTask();

            // Process task
            if (obTask != null)
            {
                if (m_hmService.ContainsKey(obTask.GetTaskType()))
                {
                    BaseService obService = m_hmService[obTask.GetTaskType()];
                    BaseContext obContext = obTask.GetContext();
                    if (obContext != null)
                    {
                        int iResult = obService.ProcessRequest(obContext);
                        if (iResult != 0)
                        {
                            // Processing task failed
                        }
                    }
                }
                else
                {
                    // Receive strange request
                }
            }
        }

        public void PushTask(Task obTask)
        {
            bool bQueueIsEmpty = false;

            // Enqueue
            lock (m_mtxQueueWrite)
            {
                while (m_iQueueCurrentSize == m_iQueueMaxSize)
                {
                    // Wait here if queue is full
                    m_evtFullCondition.WaitOne();
                }

                // Check queue is empty to notify empty condition
                if (m_iQueueCurrentSize == 0)
                {
                    bQueueIsEmpty = true;
                }

                // Write task to the last
                m_queTaskQueue.Enqueue(obTask);

                // Notify empty condition if any waiting
                if (bQueueIsEmpty)
                {
                    m_evtEmptyCondition.Set();
                }
            }
        }

        private Task GetTask()
        {
            // Dequeue
            bool bQueueIsFull = false;
            Task obRetTask = null;
            lock (m_mtxQueueRead)
            {
                while (m_iQueueCurrentSize == 0)
                {
                    // Wait here if queue is empty
                    m_evtEmptyCondition.WaitOne();
                }

                // Check queue is full to notify full condition
                if (m_iQueueCurrentSize == m_iQueueMaxSize)
                {
                    bQueueIsFull = true;
                }

                // Get the first task
                obRetTask = m_queTaskQueue.Dequeue();

                // Notify full condition if any wait
                if (bQueueIsFull)
                {
                    m_evtFullCondition.Set();
                }

                return obRetTask;
            }
        }
    }
}