namespace Service
{
    public class Authenticate : BaseService
    {
        public Authenticate(int iServiceID) : base(iServiceID)
        {
        }

        public int ProcessRequest(TCP.TcpContext obTcpContext)
        {
            return 0;
        }
    }
}