using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI;

namespace App
{
    public partial class MainFrame : Form
    {
        ChatPanel m_obChatPanel;

        public MainFrame()
        {
            // Comnponent initialization
            InitializeComponent();
            PopulateComponent();

            // Event change
            this.Resize += MainFramOnResize;
        }

        public void PopulateComponent()
        {
            m_obChatPanel = new UI.ChatPanel(this);
            m_obChatPanel.Initialize();
            this.Controls.Add(m_obChatPanel);
            this.Invalidate();
        }

        private void MainFramOnResize(object obSender, EventArgs eResize)
        {
        }
    }
}
