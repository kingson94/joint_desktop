using System.Threading;

namespace Core
{
    public class BaseThread
    {
        private int m_iThreadID;
        private Thread m_tThread;

        private bool m_bIsBackground;

        public BaseThread(int iThreadID)
        {
            m_iThreadID = iThreadID;
            m_bIsBackground = false;
        }

        public int GetThreadID()
        {
            return m_iThreadID;
        }

        public void SetBackground(bool bIsBackground)
        {
            m_bIsBackground = bIsBackground;
        }

        public virtual void Start()
        {
            m_tThread = new Thread(new ThreadStart(Run));
            m_tThread.IsBackground = m_bIsBackground;
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