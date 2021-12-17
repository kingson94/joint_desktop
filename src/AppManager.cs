using Core;
using System.Collections.Generic;

namespace App
{
    public class AppManager
    {
        private Dictionary<string, Component> m_hmComponent;
        public AppManager()
        {
            m_hmComponent = new Dictionary<string, Component>();
        }

        public void RegisterComponent()
        {
            // Component obEngineComponent = new Component(Global.ENGINE_COMP);
            Component obTcpClientComponent = new TCP.Client();

            // RegisterComponent(obEngineComponent);
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

        public void Init()
        {
            foreach (var obComponent in m_hmComponent)
            {
                obComponent.Value.Init();
            }
        }
    }
}