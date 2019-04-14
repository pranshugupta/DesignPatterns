using BridgeLibrary.BaseLibrary;

namespace BridgeLibrary.ImplementationLibrary.MessageImplementation
{
    public class SystemMessage : Message
    {
        public override void Send()
        {
            MessageSender.SendMessage(Subject, Body);
        }
    }
}
