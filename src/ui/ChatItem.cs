using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    class ChatItem
    {
        ChatPanel m_obChatPanel;
        private string m_strAvatar;
        private Image m_imgAvatar;
        private string m_strChatName;
        private string m_strLastMessage;
        private Size m_ptSize;

        // Graphic tools
        private System.Drawing.Font m_fntChatName;
        private System.Drawing.Font m_fntLastMessage;
        private System.Drawing.Rectangle m_rcChatName;
        private StringFormat m_sfChatName;

        public void SetChatName(string strChatName)
        {
            m_strChatName = strChatName;
        }

        public void SetLastMessage(string strLastMessage)
        {
            m_strLastMessage = strLastMessage;
        }

        public ChatItem(ChatPanel obChatPanel)
        {
            this.m_obChatPanel = obChatPanel;
            m_rcChatName = new Rectangle(m_obChatPanel.Left, m_obChatPanel.Top, m_obChatPanel.Width, m_obChatPanel.Height / 2);
            m_sfChatName = new StringFormat();
            m_sfChatName.Alignment = StringAlignment.Near;
        }

        public void Draw(DrawItemEventArgs eDrawItem)
        {
            if (m_strChatName.Length > 0)
            {
                eDrawItem.Graphics.DrawString(m_strChatName, m_fntChatName, Brushes.Black, m_rcChatName, m_sfChatName);
            }
        }
    }
}