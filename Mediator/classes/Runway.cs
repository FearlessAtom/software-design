namespace Mediator;

public class Runway
{
    public readonly Guid Id = Guid.NewGuid();

    public bool IsAvailable { get; set; } = true;
    public ICommandCenter CommandCenter { get; set; }

    public Runway(ICommandCenter CommandCenter)
    {
        this.CommandCenter = CommandCenter;
        this.CommandCenter.AddRunway(this);
    }

    public void HighLightRed()
    {
        Console.WriteLine($"Runway {this.Id} is busy!");
    }

    public void HighLightGreen()
    {
        Console.WriteLine($"Runway {this.Id} is free!");
    }
}
