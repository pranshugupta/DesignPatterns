using BridgeLibrary.BaseLibrary;
using System;

namespace BridgeLibrary.ImplementationLibrary.MessageSenderImplementation
{
    public class EmailSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine("Email Sender:-\n\tSubject: {0}\n\tBody: {1}", subject, body);
            Console.WriteLine("------------------------------------------");
        }
    }
}
