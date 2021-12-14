using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class MainFrame : Form
    {

        private TCP.Client m_tcpClient = null;
        public MainFrame()
        {
            // Comnponent initialization
            InitializeComponent();
            PopulateComponent();
            // Event change
            m_tcpClient = new TCP.Client();
            m_tcpClient.Connect("192.168.245.135", 8012);
            this.Resize += MainFramOnResize;
        }

        public void PopulateComponent()
        {
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

            m_lsbChatPanel.Height = this.Height;
            m_tcpClient.SendData("Hello");
        }
    }
}
