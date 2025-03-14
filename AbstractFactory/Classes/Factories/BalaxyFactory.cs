namespace AbstractFactory;

public class BalaxyFactory : IDeviceFactory
{
    public Laptop CreateLaptop()
    {
        Console.WriteLine("Creating a Balaxy laptop...");

        Thread.Sleep(1500);
        
        Console.WriteLine("Done!");

        return new BalaxyLaptop();
    }

    public Netbook CreateNetbook()
    {
        Console.WriteLine("Creating a Balaxy netbook...");

        Thread.Sleep(1500);
        
        Console.WriteLine("Done!");

        return new BalaxyNetbook();
    }

    public EBook CreateEBook()
    {
        Console.WriteLine("Creating a Balaxy E-book...");

        Thread.Sleep(1500);
        
        Console.WriteLine("Done!");

        return new BalaxyEBook();
    }

    public Smartphone CreateSmartphone()
    {
        Console.WriteLine("Creating a Balaxy smartphone...");

        Thread.Sleep(1500);
        
        Console.WriteLine("Done!");

        return new BalaxySmartphone();
    }
}
