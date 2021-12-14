using System.Net.Sockets;
using System.IO;

namespace TCP
{
    public class Client
    {
        private string m_strHost;
        private int m_iPort;
        protected Connection m_obConnection;
        public Client()
        {
        }

        public int Connect(string strHost, int iPort)
        {
            Stream sSocket;
            m_strHost = strHost;
            m_iPort = iPort;

            TcpClient obTcpClient = new TcpClient();
            obTcpClient.Connect(strHost, iPort);
            sSocket = obTcpClient.GetStream();
            m_obConnection = new Connection(ref sSocket);
            
            return 0;
        }

        public int SendData(string strMessage)
        {
            return m_obConnection.WriteSocket(strMessage);
        }
    }
}
