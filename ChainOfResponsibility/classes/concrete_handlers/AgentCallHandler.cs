namespace ChainOfResponsibility;

public class AgentCallHandler : Handler
{
    public override bool HandleRequest()
    {
        Console.Write("Would you like to speak with an agent now? (y/n): ");
        string input = Console.ReadLine()?.ToLower() ?? "";

        if (input != "y")
        {
            return false;
        }

        Console.WriteLine("Connecting you to an agent. Please wait...");
        return true;
    }
}
