using BridgeLibrary.BaseLibrary;
using System;

namespace BridgeLibrary.ImplementationLibrary.MessageSenderImplementation
{
    public class MSMQSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine("MSMQ Sender:-\n\tSubject: {0}\n\tBody: {1}", subject, body);
            Console.WriteLine("------------------------------------------");
        }
    }
}
