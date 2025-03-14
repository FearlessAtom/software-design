namespace AbstractFactory;

public class IProneFactory : IDeviceFactory
{
    public Laptop CreateLaptop()
    {
        Console.WriteLine("Creating an Iprone laptop...");

        Thread.Sleep(1500);
        
        Console.WriteLine("Done!");

        return new IProneLaptop();
    }

    public Netbook CreateNetbook()
    {
        Console.WriteLine("Creating an Iprone netbook...");

        Thread.Sleep(1500);
        
        Console.WriteLine("Done!");

        return new IProneNetbook();
    }

    public EBook CreateEBook()
    {
        Console.WriteLine("Creating an Iprone E-book...");

        Thread.Sleep(1500);
        
        Console.WriteLine("Done!");

        return new IProneEBook();
    }

    public Smartphone CreateSmartphone()
    {
        Console.WriteLine("Creating an Iprone smartphone...");

        Thread.Sleep(1500);
        
        Console.WriteLine("Done!");

        return new IProneSmartphone();
    }
}
