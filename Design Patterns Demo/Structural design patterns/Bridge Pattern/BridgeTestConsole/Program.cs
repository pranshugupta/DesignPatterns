using System;
using BridgeLibrary.BaseLibrary;
using BridgeLibrary.ImplementationLibrary.MessageImplementation;
using BridgeLibrary.ImplementationLibrary.MessageSenderImplementation;
namespace BridgeTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Message systemMessage = new SystemMessage()
            {
                Subject = "System Message Subject",
                Body = "System Message Body"
            };

            Message userMessage = new UserMessage()
            {
                Subject = "ser Message Subject",
                Body = "ser Message Body",
                UserComment = "User Message Comments"
            };

            IMessageSender emailSender = new EmailSender();
            IMessageSender msmqSender = new MSMQSender();
            IMessageSender webServiceSender = new WebServiceSender();

            SendMyMessage(systemMessage, emailSender);
            SendMyMessage(systemMessage, msmqSender);
            SendMyMessage(systemMessage, webServiceSender);
            SendMyMessage(userMessage, emailSender);
            SendMyMessage(userMessage, msmqSender);
            SendMyMessage(userMessage, webServiceSender);

            Console.ReadKey();
        }

        static void SendMyMessage(Message message, IMessageSender sender)
        {
            message.MessageSender = sender;
            message.Send();
        }
    }
}
