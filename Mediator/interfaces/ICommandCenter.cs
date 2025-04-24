namespace Mediator;

public interface ICommandCenter
{
    public void AddRunway(Runway Runway);
    public void RequestLanding(Aircraft Aircraft);
    public void RequestTakeoff(Aircraft Aircraft);
}
