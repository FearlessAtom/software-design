namespace Mediator;

public class CommandCenter : ICommandCenter
{
    public Dictionary<Runway, Aircraft?> RunwayAircraft = new Dictionary<Runway, Aircraft?>();

    public void AddRunway(Runway Runway)
    {
        if (this.RunwayAircraft.ContainsKey(Runway))
        {
            throw new Exception($"Runway {Runway.Id} aready exists!");
        }

        this.RunwayAircraft.Add(Runway, null);
    }

    public void RequestLanding(Aircraft Aircraft)
    {
        Console.WriteLine($"Requesting landing for {Aircraft.Id}");

        foreach (Runway Runway in this.RunwayAircraft.Keys)
        {
            if (Runway.IsAvailable)
            {
                RunwayAircraft[Runway] = Aircraft;
                Aircraft.IsLanded = true;
                Runway.IsAvailable = false;
                Runway.HighLightRed();
                Console.WriteLine("Landing granted!");

                return;
            }
        }
    }

    public void RequestTakeoff(Aircraft Aircraft)
    {
        Console.WriteLine($"Requesting takeoff for {Aircraft.Id}");

        foreach (Runway Runway in RunwayAircraft.Keys)
        {
            if (RunwayAircraft[Runway] == Aircraft)
            {
                Runway.IsAvailable = true;
                Aircraft.IsLanded = false;
                RunwayAircraft[Runway] = null;
                Runway.HighLightGreen();
                Console.WriteLine("Takeoff granted!");

                return;
            }
        }
    }
}
