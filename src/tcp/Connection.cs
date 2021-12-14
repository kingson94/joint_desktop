using System.Net.Sockets;
using System.IO;
using System.Linq;

namespace TCP
{
    public class Connection
    {
        private Stream m_sSocket;
        public Connection(ref Stream sSocket)
        {
            m_sSocket = sSocket;
        }

        public int WriteSocket(string strData)
        {
            try
            {
                byte[] szData = System.Text.Encoding.UTF8.GetBytes(strData);
                m_sSocket.Write(szData);
            }
            catch (System.Exception ex)
            {
                // Write socket get error
                return -1;
            }
            return 0;
        }
    }
} // namespace TCP