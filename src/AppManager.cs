using Core;
using System.Collections.Generic;

namespace App
{
    public class AppManager
    {
        private static AppManager m_sAppInstance = null;
        private Dictionary<string, Component> m_hmComponent;
        UI.ChatFrame frmChat = null;
        UI.LoginFrame frmLogin = null;
        public AppManager()
        {
            m_hmComponent = new Dictionary<string, Component>();
            frmLogin = new UI.LoginFrame();
            frmChat = new UI.ChatFrame();

            frmLogin.FormClosed += OnLoginClosed;
        }

        public static void CreateInstance()
        {
            m_sAppInstance = new AppManager();
        }

        public static AppManager GetInstance()
        {
            return m_sAppInstance;
        }
        
        public int Login(string strUserName, string strPassword)
        {
            try
            {
                Start();
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.ToString());
                return 1;
            }

            return 0;
        }

        public void RegisterComponent()
        {
            Component obEngineComponent = new Core.Engine();
            Component obTcpClientComponent = new TCP.Client();

            RegisterComponent(obEngineComponent);
            RegisterComponent(obTcpClientComponent);
        }

        private void RegisterComponent(Component obComponent)
        {
            if (m_hmComponent.ContainsKey(obComponent.GetID()) == false)
            {
                m_hmComponent.Add(obComponent.GetID(), obComponent);
            }
            else
            {
                // Component exists
            }
        }

        public Component GetComponent(string strComponentID)
        {
            if (m_hmComponent.ContainsKey(strComponentID) == true)
            {
                return m_hmComponent[strComponentID];
            }
            
            return null;
        }

        public void Init()
        {
            foreach (var obComponent in m_hmComponent)
            {
                obComponent.Value.Init();
            }
        }

        public void Start()
        {
            foreach (var obComponent in m_hmComponent)
            {
                obComponent.Value.Start();
            }
        }

        public void OnLoginClosed(object obSender, System.EventArgs evtClose)
        {
            System.Windows.Forms.Application.Exit();
        }

        // 0 - Sessioned
        // 1 - Not Authenticated
        public int ValidateAuthentication()
        {
            return 1;
        }

        public void Run()
        {
            RegisterComponent();
            Init();
            if (ValidateAuthentication() == 0)
            {
                Start();
                // Show chat frame
                frmChat.Show();
            }
            else
            {
                // Show login frame
                frmLogin.Show();
            }
        }
    }
}