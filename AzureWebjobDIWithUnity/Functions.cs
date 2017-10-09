namespace AzureWebjobDIWithUnity
{
    using System;
    using System.IO;
    using Logic;
    using Microsoft.Azure.WebJobs;


    public class Functions
    {
        private readonly IMessageLogic _messageLogic;

        public Functions(IMessageLogic messageLogic)
        {
            _messageLogic = messageLogic;
        }

        public void ProcessQueueMessage([QueueTrigger("queue")] string name, TextWriter log)
        {
            Console.WriteLine(_messageLogic.GetMessage(name));
        }
    }
}
