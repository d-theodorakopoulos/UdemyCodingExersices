using System;
using System.Collections.Generic;

namespace WorkFlowEngineApp
{
    class Program
    {
        static void Main (string[] args)
        {
            WorkFlow myWorkFlow = new WorkFlow();

            UploadVideo upload = new UploadVideo();
            SendMail send = new SendMail();
            EncodingProcess encoding = new EncodingProcess();

            myWorkFlow.Actions = new List<IAction>() { upload, send, encoding };

            ((SendMail)myWorkFlow.Actions[0]).Execute();

            WorkFlowEngine engine = new WorkFlowEngine(myWorkFlow);

            engine.Run();

            Console.ReadKey();
        }
    }
}
