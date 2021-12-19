using System;
using System.Windows.Forms;
using App;

namespace UI
{
    public partial class ChatFrame : Form
    {
        private AppManager m_obApp;
        public ChatFrame()
        {
            // Comnponent initialization
            InitializeComponent();

            // Event change
            this.Resize += FrameOnResize;
        }

        private void FrameOnResize(object obSender, EventArgs eResize)
        {
            if (this.Width <= (int) (this.MinimumSize.Width * 13/10))
            {
                m_lsbChatPanel.Width = this.Width;
            }
            else
            {
                m_lsbChatPanel.Width = (int) (this.Width * 45/100);
            }

            m_lsbChatPanel.Height = this.Bottom - m_lsbChatPanel.Top;
        }
    }
}
