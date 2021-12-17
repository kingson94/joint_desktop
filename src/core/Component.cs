namespace Core
{
    public class Component
    {
        private string m_strComponentID;
        private bool m_bIsInit;
        public Component(string strComponentID)
        {
            m_strComponentID = strComponentID;
            m_bIsInit = false;
        }

        public virtual void Run()
        {
        }

        public virtual void Join()
        {
        }

        public virtual void Init()
        {
            m_bIsInit = true;
        }

        public string GetID()
        {
            return m_strComponentID;
        }
    }
}