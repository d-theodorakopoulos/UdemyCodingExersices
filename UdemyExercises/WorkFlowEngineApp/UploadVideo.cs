
using System;

namespace WorkFlowEngineApp
{
    public class SendMail : IAction
    {
        public void Execute ()
        {
            Console.WriteLine("Sending Mail");
        }
    }
    public class EncodingProcess : IAction
    {
        public void Execute ()
        {
            Console.WriteLine("Video Encoding");
        }
    }
    public class UploadVideo : IAction
    {
        public void Execute ()
        {
            Console.WriteLine("Video Uploaded");
        }
    }
}
