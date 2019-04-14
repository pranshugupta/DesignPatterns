using BridgeLibrary.BaseLibrary;

namespace BridgeLibrary.ImplementationLibrary.MessageImplementation
{
    public class UserMessage : Message
    {
        public string UserComment { get; set; }
        public override void Send()
        {
            string fullBody = string.Format("{0}\n\tUser Comments:{1}",Body, UserComment);
            MessageSender.SendMessage(Subject, fullBody);
        }
    }
}
