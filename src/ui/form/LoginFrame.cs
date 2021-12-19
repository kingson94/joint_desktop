using System;
using System.Windows.Forms;
using App;

namespace UI
{
    public partial class LoginFrame : Form
    {
        private System.Drawing.Point m_ptPreMouseMove;
        private bool m_bMouseDown;
        public LoginFrame()
        {
            // Comnponent initialization
            InitializeComponent();
            m_bMouseDown = false;

            // Event change
            this.Resize += OnFrameResize;
            this.MouseDown += OnMouseDown;
            this.MouseUp += OnMouseUp;
            this.MouseMove += OnMouseMove;
        }

        public int CheckAuthorize()
        {
            return 0;
        }

        private void OnBtnLoginClicked(object obSender, EventArgs evtClicked)
        {
            int iLoginResult = -1;
            iLoginResult = AppManager.GetInstance().Login(m_txtUserName.Text, m_txtPassword.Text);
            if (iLoginResult != 0)
            {
                MessageBox.Show("Connect failed");
            }
        }

        private void OnBtnCloseClicked(object obSender, EventArgs evtClicked)
        {
            this.Close();
        }

        private void OnFrameResize(object obSender, EventArgs evtResize)
        {
        }

        private void OnMouseDown(object obSender, MouseEventArgs evtMouse)
        {
            if (evtMouse.Button == MouseButtons.Left)
            {
                m_bMouseDown = true;
                m_ptPreMouseMove = new System.Drawing.Point(evtMouse.Location.X, evtMouse.Location.Y);
            }
        }

        private void OnMouseUp(object obSender, MouseEventArgs evtMouse)
        {
            if (evtMouse.Button == MouseButtons.Left && m_bMouseDown)
            {
                m_bMouseDown = false;
            }
        }

        private void OnMouseMove(object obSender, MouseEventArgs evtMouse)
        {
            if (m_bMouseDown)
            {
                if (evtMouse.Button == MouseButtons.Left)
                {
                    this.Location = new System.Drawing.Point(this.Location.X + evtMouse.Location.X - m_ptPreMouseMove.X
                                , this.Location.Y + evtMouse.Location.Y - m_ptPreMouseMove.Y);
                }
            }
        }
    }
}
