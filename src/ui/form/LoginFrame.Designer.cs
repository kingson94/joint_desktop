namespace UI
{
    partial class LoginFrame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer obComponents = null;
        private System.Windows.Forms.Label m_lblWelcome;
        private System.Windows.Forms.Label m_lblUserName;
        private UI.TSTextBox m_txtUserName;
        private System.Windows.Forms.Label m_lblPassword;
        private UI.TSTextBox m_txtPassword;
        private System.Windows.Forms.CheckBox m_ckbRemember;
        private System.Windows.Forms.Button m_btnLogin;
        private System.Windows.Forms.Button m_btnClose;
        private System.Windows.Forms.PictureBox m_picIntro;
        private System.Windows.Forms.LinkLabel m_lnkRegister;
        private System.Windows.Forms.LinkLabel m_lnkForgotPassword;
        private int m_iBorderPadding;

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
            string strFontName = "Segoe UI";
            this.obComponents = new System.ComponentModel.Container();
            m_iBorderPadding = 5;
            this.SuspendLayout();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Joint desktop";
            this.Name = "frmChatFrame";
            this.Icon = new System.Drawing.Icon(@"asset\joint.ico");
            this.Size = new System.Drawing.Size(640, 480);
            this.MinimumSize = this.Size;
            this.MaximumSize = this.MinimumSize;
            this.BackgroundImage = System.Drawing.Image.FromFile(@"asset\login_background.jpg");
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.BackColor = System.Drawing.Color.White;

            m_btnClose = new System.Windows.Forms.Button();
            m_btnClose.Width = 32;
            m_btnClose.Height = 32;
            m_btnClose.Left = this.Width - m_btnClose.Width - 5;
            m_btnClose.Top = this.Top + 5;
            m_btnClose.Name = "btnClose";
            m_btnClose.Text = "";
            m_btnClose.BackgroundImage = System.Drawing.Image.FromFile(@"asset\button_close.png");
            m_btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            m_btnClose.BackColor = System.Drawing.Color.White;
            m_btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            m_btnClose.Click += OnBtnCloseClicked;

            m_picIntro = new System.Windows.Forms.PictureBox();
            m_picIntro.Top = this.Top + m_iBorderPadding;
            m_picIntro.Left = this.Left + m_iBorderPadding;
            m_picIntro.Width = this.Width *45/100 - m_iBorderPadding*2;
            m_picIntro.Height = this.Height - m_iBorderPadding*2;
            m_picIntro.Image = System.Drawing.Image.FromFile(@"asset\login_intro.png");
            m_picIntro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            m_picIntro.BackColor = System.Drawing.Color.FromArgb(189, 183, 107);

            m_lblWelcome = new System.Windows.Forms.Label();
            m_lblWelcome.AutoSize = false;
            m_lblWelcome.Left = m_picIntro.Left + m_picIntro.Width + m_iBorderPadding;
            m_lblWelcome.Width = this.Width - m_lblWelcome.Left - m_iBorderPadding;
            m_lblWelcome.Height = 100;
            m_lblWelcome.Font = new System.Drawing.Font(strFontName, 30);
            m_lblWelcome.Top = m_btnClose.Top + m_btnClose.Height + 10;
            m_lblWelcome.Name = "lblWelcome";
            m_lblWelcome.Text = "Welcome to Joint";
            m_lblWelcome.BackColor = System.Drawing.Color.Transparent;
            m_lblWelcome.ForeColor = System.Drawing.Color.White;
            m_lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter; 

            m_lblUserName = new System.Windows.Forms.Label();
            m_lblUserName.AutoSize = false;
            m_lblUserName.Width = this.Width * 4/10;
            m_lblUserName.Left = (m_picIntro.Left + m_picIntro.Width + this.Width - m_lblUserName.Width)/2;
            m_lblUserName.Top = m_lblWelcome.Top + m_lblWelcome.Height + 25;
            m_lblUserName.Name = "lblUserName";
            m_lblUserName.Text = "Username";
            m_lblUserName.Font = new System.Drawing.Font(strFontName, 10);
            m_lblUserName.BackColor = System.Drawing.Color.Transparent;
            m_lblUserName.ForeColor = System.Drawing.Color.White;

            m_txtUserName = new UI.TSTextBox();
            m_txtUserName.Width = this.Width * 4/10;
            m_txtUserName.Left = m_lblUserName.Left;
            m_txtUserName.Top = m_lblUserName.Top + m_lblUserName.Height + 2;
            m_txtUserName.Name = "txtUserName";
            m_txtUserName.Font = new System.Drawing.Font(strFontName, 9.5F);
            m_txtUserName.BackColor = System.Drawing.Color.White;
            m_txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            m_lblPassword = new System.Windows.Forms.Label();
            m_lblPassword.AutoSize = false;
            m_lblPassword.Width = this.Width * 3/10;
            m_lblPassword.Left = m_txtUserName.Left;
            m_lblPassword.Top = m_txtUserName.Top + m_txtUserName.Height + 10;
            m_lblPassword.Name = "lblPassword";
            m_lblPassword.Text = "Password";
            m_lblPassword.Font = new System.Drawing.Font(strFontName, 10);
            m_lblPassword.BackColor = System.Drawing.Color.Transparent;
            m_lblPassword.ForeColor = System.Drawing.Color.White;

            m_txtPassword = new UI.TSTextBox();
            m_txtPassword.Width = this.Width * 4/10;
            m_txtPassword.Left = m_lblPassword.Left;
            m_txtPassword.Top = m_lblPassword.Top + m_lblPassword.Height + 2;
            m_txtPassword.Name = "txtPassword";
            m_txtPassword.BackColor = System.Drawing.Color.White;
            m_txtPassword.UseSystemPasswordChar = true;
            m_txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            m_ckbRemember = new System.Windows.Forms.CheckBox();
            m_ckbRemember.Checked = false;
            m_ckbRemember.Name = "ckbRemember";
            m_ckbRemember.Text = "Remember me";
            m_ckbRemember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            m_ckbRemember.Left = m_txtPassword.Left + 1;
            m_ckbRemember.Font = new System.Drawing.Font(strFontName, 9.5f);
            m_ckbRemember.Top = m_txtPassword.Top + m_txtPassword.Height + 10;
            m_ckbRemember.BackColor = System.Drawing.Color.Transparent;
            m_ckbRemember.ForeColor = System.Drawing.Color.FromArgb(75, 154, 180);

            m_lnkForgotPassword = new System.Windows.Forms.LinkLabel();
            m_lnkForgotPassword.Name = "lnkForgotPassword";
            m_lnkForgotPassword.Text = "Forgot password";
            m_lnkForgotPassword.LinkColor = System.Drawing.Color.FromArgb(189, 183, 107);
            m_lnkForgotPassword.VisitedLinkColor = m_lnkForgotPassword.LinkColor;
            m_lnkForgotPassword.ActiveLinkColor = m_lnkForgotPassword.LinkColor;
            m_lnkForgotPassword.DisabledLinkColor = m_lnkForgotPassword.LinkColor;
            m_lnkForgotPassword.AutoSize = false;
            m_lnkForgotPassword.Width = this.Width - m_ckbRemember.Left - m_ckbRemember.Width - 10;
            m_lnkForgotPassword.Left = m_txtPassword.Left + m_txtPassword.Width - m_lnkForgotPassword.Width + 3;
            m_lnkForgotPassword.Top = m_ckbRemember.Top;
            m_lnkForgotPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            m_lnkForgotPassword.Font = new System.Drawing.Font(strFontName, 9.5F, System.Drawing.FontStyle.Underline);
            m_lnkForgotPassword.BackColor = System.Drawing.Color.Transparent;

            m_btnLogin = new System.Windows.Forms.Button();
            m_btnLogin.Width = this.Width * 4/10;
            m_btnLogin.Height = 30;
            m_btnLogin.Left = m_ckbRemember.Left;
            m_btnLogin.Top = m_ckbRemember.Top + m_ckbRemember.Height + 20;
            m_btnLogin.Name = "btnLogin";
            m_btnLogin.Text = "Login";
            m_btnLogin.BackColor = System.Drawing.Color.White;
            m_btnLogin.ForeColor = System.Drawing.Color.Black;
            m_btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            m_btnLogin.Click += OnBtnLoginClicked;

            m_lnkRegister = new System.Windows.Forms.LinkLabel();
            m_lnkRegister.Name = "lnkRegister";
            m_lnkRegister.Text = "Create a new account";
            m_lnkRegister.LinkColor = System.Drawing.Color.FromArgb(189, 183, 107);
            m_lnkRegister.VisitedLinkColor = m_lnkRegister.LinkColor;
            m_lnkRegister.ActiveLinkColor = m_lnkRegister.LinkColor;
            m_lnkRegister.DisabledLinkColor = m_lnkRegister.LinkColor;
            m_lnkRegister.AutoSize = false;
            m_lnkRegister.Width = this.Width * 3/10;
            m_lnkRegister.Left = m_btnLogin.Left;
            m_lnkRegister.Top = m_btnLogin.Top + m_btnLogin.Height + 10;
            m_lnkRegister.Font = new System.Drawing.Font(strFontName, 12, System.Drawing.FontStyle.Underline);
            m_lnkRegister.BackColor = System.Drawing.Color.Transparent;

            this.Controls.Add(m_picIntro);
            this.Controls.Add(m_lblWelcome);
            this.Controls.Add(m_lblUserName);
            this.Controls.Add(m_txtUserName);
            this.Controls.Add(m_lblPassword);
            this.Controls.Add(m_txtPassword);
            this.Controls.Add(m_btnLogin);
            this.Controls.Add(m_btnClose);
            this.Controls.Add(m_lnkRegister);
            this.Controls.Add(m_ckbRemember);
            this.Controls.Add(m_lnkForgotPassword);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}