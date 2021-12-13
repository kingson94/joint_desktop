namespace App
{
    partial class MainFrame
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
            this.Name = "frmMainFrame";
            this.Icon = new System.Drawing.Icon("asset\\joint.ico");
            this.MinimumSize = new System.Drawing.Size(400, 600);

            m_lsbChatPanel = new UI.ChatPanel();
            m_lsbChatPanel.Name = "pnlChat";
            // m_lsbChatPanel.Width = (int) (this.Width * 33/100);
            m_lsbChatPanel.Width = this.MinimumSize.Width;
            m_lsbChatPanel.MinimumSize = this.MinimumSize;
            m_lsbChatPanel.BackColor = System.Drawing.Color.DarkCyan;
            m_lsbChatPanel.Anchor = (System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom
                                    | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Top);
            m_lsbChatPanel.Height = this.Height;
            m_lsbChatPanel.BorderStyle = System.Windows.Forms.BorderStyle.None;

            txtLog = new System.Windows.Forms.TextBox();
            txtLog.Width = this.Width;
            txtLog.Height = 100;
            txtLog.Multiline = true;
            txtLog.Top = this.Height - txtLog.Height;
            txtLog.Left = this.Left;


            this.Controls.Add(txtLog);
            this.Controls.Add(m_lsbChatPanel);
        }
    }
}

