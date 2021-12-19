namespace Core
{
    public class Component
    {
        protected string m_strComponentID;
        protected bool m_bIsInit;
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

        public virtual void Start()
        {
        }

        public string GetID()
        {
            return m_strComponentID;
        }
    }
}