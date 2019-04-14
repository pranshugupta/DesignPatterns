namespace BridgeLibrary.BaseLibrary
{
    public abstract class Message
    {
        public IMessageSender MessageSender { get; set; }
        public abstract void Send();

        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
