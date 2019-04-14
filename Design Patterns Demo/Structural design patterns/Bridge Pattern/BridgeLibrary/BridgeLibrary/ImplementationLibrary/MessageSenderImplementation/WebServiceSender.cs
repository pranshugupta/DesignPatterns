using BridgeLibrary.BaseLibrary;
using System;

namespace BridgeLibrary.ImplementationLibrary.MessageSenderImplementation
{
    public class WebServiceSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine("Web Service Sender:-\n\tSubject: {0}\n\tBody: {1}", subject, body);
            Console.WriteLine("------------------------------------------");
        }
    }
}
