namespace ChainOfResponsibility;

public class HardwareHandler : Handler
{
    public override bool HandleRequest()
    {
        Console.Write("Is your issue harware related? (y/n): ");
        string input = Console.ReadLine()?.ToLower() ?? "";

        if (input != "y")
        {
            return false;
        }

        Console.WriteLine("Please check your cables and make sure your hardware is properly connected.");
        Console.WriteLine("If the issue persists, consider restarting your device.");

        return true;
    }
}
