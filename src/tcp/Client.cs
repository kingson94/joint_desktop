using System.Net.Sockets;
using System.IO;
using Core;
using Newtonsoft.Json.Linq;

namespace TCP
{
    public class Client : Component
    {
        private string m_strHost;
        private int m_iPort;
        protected Connection m_obConnection;
        public Client() : base(Global.TCP_CLIENT_COMP)
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
            Message obMessage = new Message(strMessage, 5);
            return m_obConnection.WriteSocket(obMessage);
        }

        public override void Init()
        {
            base.Init();
            JObject jConfig = null;
            Util.JsonFromFile(Global.CLIENT_CONFIG, ref jConfig);
            if (jConfig != null)
            {
                m_strHost = (string) jConfig["connection"]["tcp_host"];
                m_iPort = (int) jConfig["connection"]["tcp_port"];
            }
            else
            {
                // Json config load failed
            }
            Core.BaseThread p = new BaseThread(1);
            p.Start();
        }
    }
}
