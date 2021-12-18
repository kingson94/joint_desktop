namespace UI
{
    partial class ChatFrame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer obComponents = null;
        private UI.ChatPanel m_lsbChatPanel;
        private System.Windows.Forms.TextBox txtLog;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="bDisposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool bDisposing)
        {
            if (bDisposing && (obComponents != null))
            {
                obComponents.Dispose();
            }
            base.Dispose(bDisposing);
        }

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.obComponents = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(960, 640);
            this.Text = "Joint desktop";
            this.Name = "frmChatFrame";
            this.Icon = new System.Drawing.Icon("asset\\joint.ico");
            this.MinimumSize = new System.Drawing.Size(400, 600);

            m_lsbChatPanel = new UI.ChatPanel();
            m_lsbChatPanel.Name = "pnlChat";
            m_lsbChatPanel.Width = (int) (this.Width * 45/100);
            m_lsbChatPanel.BackColor = System.Drawing.Color.White;
            m_lsbChatPanel.Height = this.Height;
            m_lsbChatPanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            m_lsbChatPanel.SelectionMode = System.Windows.Forms.SelectionMode.One;

            UI.exListBoxItem i = new UI.exListBoxItem(1,"fdsfds", "sdfsdf", null);
            m_lsbChatPanel.Items.Add(i);
            
            txtLog = new System.Windows.Forms.TextBox();
            txtLog.Width = this.Width;
            txtLog.Height = 100;
            txtLog.Multiline = true;
            txtLog.Top = this.Height - txtLog.Height;
            txtLog.Left = this.Left;
            // txtLog.Visible = false;

            this.Controls.Add(txtLog);
            this.Controls.Add(m_lsbChatPanel);
        }
    }
}

