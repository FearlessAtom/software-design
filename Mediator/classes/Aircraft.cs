namespace Mediator;

public class Aircraft
{
    public readonly Guid Id = Guid.NewGuid();
    
    public bool IsLanded = false;
    public ICommandCenter CommandCenter;

    public Aircraft(ICommandCenter CommandCenter)
    {
        this.CommandCenter = CommandCenter;
    }

    public void Land(Runway runway)
    {
        if (IsLanded)
        {
            throw new Exception($"Aircraft {Id.ToString()} is already landed!");
        }

        CommandCenter?.RequestLanding(this);
    }

    public void TakeOff(Runway Runway)
    {
        if (!IsLanded)
        {
            throw new Exception($"Aircraft {Id.ToString()} is already in the air!");
        }

        CommandCenter?.RequestTakeoff(this);
    }
}
