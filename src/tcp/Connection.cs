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

        public int WriteSocket(Message obMessage)
        {
            try
            {
                string strMessage = "";
                obMessage.GetEncodedMessage(ref strMessage);
                byte[] szData = System.Text.Encoding.UTF8.GetBytes(strMessage);
                m_sSocket.Write(szData, 0, szData.Length);
            }
            catch (System.Exception ex)
            {
                // Write socket get error
                System.Console.WriteLine(ex.ToString());
                return -1;
            }
            return 0;
        }
    }
} // namespace TCP