using Core;
using System.Collections.Generic;

namespace App
{
    public class AppManager
    {
        private static AppManager m_sAppInstance = null;
        private Dictionary<string, Component> m_hmComponent;
        public AppManager()
        {
            m_hmComponent = new Dictionary<string, Component>();
        }

        public static void CreateInstance()
        {
            m_sAppInstance = new AppManager();
        }

        public static AppManager GetInstance()
        {
            return m_sAppInstance;
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
    }
}