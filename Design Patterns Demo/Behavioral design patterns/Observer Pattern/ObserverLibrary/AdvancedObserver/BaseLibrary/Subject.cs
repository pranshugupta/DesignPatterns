namespace AdvancedObserver.BaseLibrary
{
    public delegate void NotifyObserverDelegate(string key);
    public abstract class Subject
    {
        event NotifyObserverDelegate NotifyObserverEvent;

        public void Subscribe(NotifyObserverDelegate handler)
        {
            NotifyObserverEvent += handler;
        }

        public void UnSubscribe(NotifyObserverDelegate handler)
        {
            NotifyObserverEvent -= handler;
        }

        public void Notify(string name)
        {
            NotifyObserverEvent?.Invoke(name);
        }
    }
}
