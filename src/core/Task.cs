namespace Core
{
    public class Task
    {
        private int m_iType;
        private BaseContext m_obContext;

        public Task(BaseContext obContext, int iType)
        {
            m_obContext = obContext;
            m_iType = iType;
        }

        public int GetTaskType()
        {
            return m_iType;
        }

        public BaseContext GetContext()
        {
            return m_obContext;
        }
    }
} // namespace Core