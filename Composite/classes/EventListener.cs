namespace Composite;

public class EventListener : IEventListener
{
    public void Update(object sender, string EventName)
    {
        Console.WriteLine($"Event {EventName} is triggered!");

        if (sender is LightNode)
        {
            LightNode ElementNode = (LightNode)sender;

            Console.WriteLine("Element:");
            Console.WriteLine(ElementNode.GetOuterHTML());
        }
    }
}
