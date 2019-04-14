namespace BridgeLibrary.BaseLibrary
{
    public interface IMessageSender
    {
        void SendMessage(string subject, string body);
    }
}
