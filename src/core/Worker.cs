using App;

namespace Core
{
    public class Worker : BaseThread
    {
        public Worker(int iWorkerID) : base(iWorkerID)
        {
        }

        public override void Run()
        {
            AppManager obAppInstance = AppManager.GetInstance();
            if (obAppInstance != null)
            {
                Engine obEngineComp = (Engine) obAppInstance.GetComponent(Global.ENGINE_COMP);
                
                if (obEngineComp != null)
                {
                    while (true)
                    {
                        // Worker start;
                        obEngineComp.ConsumeTask();
                        // Worker end
                    }
                }
            }
        }
    }
}