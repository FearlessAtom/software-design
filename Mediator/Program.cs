namespace Mediator;

class Program
{
    static void Main(string[] args)
    {
        ICommandCenter CommandCenter = new CommandCenter();

        Runway Runway = new Runway(CommandCenter);
        Runway SecondRunway = new Runway(CommandCenter);

        Aircraft Aircraft = new Aircraft(CommandCenter);
        Aircraft SecondAircraft = new Aircraft(CommandCenter);

        CommandCenter.RequestLanding(Aircraft);
        CommandCenter.RequestLanding(SecondAircraft);

        Console.WriteLine();

        CommandCenter.RequestTakeoff(Aircraft);
        CommandCenter.RequestTakeoff(SecondAircraft);
    }
}
