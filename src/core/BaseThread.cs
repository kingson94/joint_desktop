using System.Threading;

namespace Core
{
    public class BaseThread
    {
        private int m_iThreadID;
        private Thread m_tThread;

        public BaseThread(int iThreadID)
        {
            m_iThreadID = iThreadID;
        }

        public int GetThreadID()
        {
            return m_iThreadID;
        }

        public virtual void Start()
        {
            m_tThread = new Thread(new ThreadStart(Run));
            m_tThread.Start();
            if (m_tThread == null)
            {
                // Cannot start thread
            }
        }

        public virtual void Run()
        {
        }
    }
} // namespace Core