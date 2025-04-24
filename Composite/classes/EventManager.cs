namespace Composite;

public class EventManager
{
    public Dictionary<string, List<IEventListener>> Listeners = new Dictionary<string, List<IEventListener>>();

    public void Subscribe(string EventName, IEventListener Listerner)
    {
        if (!this.Listeners.ContainsKey(EventName))
        {
            this.Listeners[EventName] = new List<IEventListener>();
        }

        this.Listeners[EventName].Add(Listerner);
    }

    public void Unsubscribe(string EventName, IEventListener Listener)
    {
        if (!this.Listeners.ContainsKey(EventName))
        {
            return;
        }

        this.Listeners[EventName].Remove(Listener);
    }

    public void Notify(string EventName)
    {
        if (!this.Listeners.ContainsKey(EventName))
        {
            return;
        }

        foreach (IEventListener Listener in this.Listeners[EventName])
        {
            Listener.Update(Listener, EventName);
        }
    }
}
