namespace Service
{
    public class BaseService
    {
        private int m_iServiceID;

        public BaseService(int iServiceID)
        {
            m_iServiceID = iServiceID;
        }

        public int GetID()
        {
            return m_iServiceID;
        }

        public virtual int ProcessRequest(Core.BaseContext obContext)
        {
            return 0;
        }
    }
}