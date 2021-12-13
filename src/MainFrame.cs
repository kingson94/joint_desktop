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

        public MainFrame()
        {
            // Comnponent initialization
            InitializeComponent();
            // Event change
            this.Resize += MainFramOnResize;
        }

        public void PopulateComponent()
        {
            
        }

        private void MainFramOnResize(object obSender, EventArgs eResize)
        {
            if (this.Width <= this.MinimumSize.Width)
            {
                // m_lsbChatPanel.Width = this.Width;
            }
            else
            {
                // m_lsbChatPanel.Width = (int) (this.Width * 33/100);
            }
                txtLog.Text = string.Format("chat width {0} - current width: {1}\r\n", m_lsbChatPanel.Width, this.Width).ToString();
        }
    }
}
