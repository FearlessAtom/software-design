namespace ChainOfResponsibility;

public class ExternalDeviceHandler : Handler
{
    public override bool HandleRequest()
    {
        Console.Write("Is your issue related to an external device? (y/n): ");
        string input = Console.ReadLine()?.ToLower() ?? "";

        if (input != "y")
        {
            return false;
        }

        Console.WriteLine("Make sure the external device is properly connected and compatible with your system.");
        Console.WriteLine("Try reconnecting or using a different port.");
        return true;
    }
}
