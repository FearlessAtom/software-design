namespace ChainOfResponsibility;

public class SoftwareHandler : Handler
{
    public override bool HandleRequest()
    {
        Console.Write("Is your issue software related? (y/n): ");
        string input = Console.ReadLine()?.ToLower() ?? "";

        if (input != "y")
        {
            return false;
        }

        Console.WriteLine("Try restarting the application or reinstalling the software.");
        Console.WriteLine("If the issue continues, check for updates or known bugs.");
        return true;
    }
}
