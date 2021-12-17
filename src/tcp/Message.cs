namespace TCP
{
    public class Message
    {
        private string m_strContent;

        private int m_iRequestID;

        public Message(string strContent, int iRequestID)
        {
            m_strContent = strContent;
            m_iRequestID = iRequestID;
        }

        public void GetEncodedMessage(ref string strEncodedMessage)
        {
            try
            {
                strEncodedMessage = "";
                int iPacketSize = m_strContent.Length + Global.TCP_HEADER_SIZE;
                byte[] szMessage = System.Text.Encoding.UTF8.GetBytes(m_strContent);
                byte[] obTmpPacket = new byte[iPacketSize];
                
                // Magic header
                obTmpPacket[0] = (byte) Global.MAGIC_PACKET_BYTE;
                obTmpPacket[1] = (byte) Global.MAGIC_PACKET_BYTE;

                // Data size
                obTmpPacket[2] = (byte) ((iPacketSize >> 24) & 0xFF);
                obTmpPacket[3] = (byte) ((iPacketSize >> 16) & 0xFF);
                obTmpPacket[4] = (byte) ((iPacketSize >> 8) & 0xFF);
                obTmpPacket[5] = (byte) (iPacketSize & 0xFF);

                // Request id
                obTmpPacket[6] = (byte) ((m_iRequestID >> 8) & 0xFF);
                obTmpPacket[7] = (byte) (m_iRequestID & 0xFF);

                // Data
                szMessage.CopyTo(obTmpPacket, 8);
                strEncodedMessage = System.Text.Encoding.UTF8.GetString(obTmpPacket);
            }
            catch (System.Exception ex)
            {
                // Encode message get error
            }
        }
    }
}