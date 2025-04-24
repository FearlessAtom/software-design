namespace ChainOfResponsibility;

class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
            IHandler Harware = new HardwareHandler();
            IHandler Software = new SoftwareHandler();
            IHandler ExternalDevice = new ExternalDeviceHandler();
            IHandler AgentCall = new AgentCallHandler();

            Harware.SetNext(Software);
            Software.SetNext(ExternalDevice);
            ExternalDevice.SetNext(AgentCall);

            bool IsIssueResolved = Harware.Handle();

            if (!IsIssueResolved)
            {
                Console.Write("Issue wasn't resolved. Would you like to try again? (y/n): ");
                string Retry = Console.ReadLine()?.ToLower() ?? "";
                if (Retry != "y") break;
            }

            else 
            {
                break;
            }
        }
    }
}
