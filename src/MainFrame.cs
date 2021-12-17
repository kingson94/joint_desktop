using System;
using System.Windows.Forms;

namespace App
{
    public partial class MainFrame : Form
    {
        private App.AppManager pApp = null;
        public MainFrame()
        {
            // Comnponent initialization
            InitializeComponent();
            pApp = new AppManager();

            // Event change
            this.Resize += MainFramOnResize;

            // Register component
            RegisterComponent();
        }

        public void RegisterComponent()
        {
            pApp.RegisterComponent();
            pApp.Init();
        }

        private void MainFramOnResize(object obSender, EventArgs eResize)
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
