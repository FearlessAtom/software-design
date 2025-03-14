namespace AbstractFactory;

public class KiaomiFactory : IDeviceFactory
{
    public Laptop CreateLaptop()
    {
        Console.WriteLine("Creating a Kiaomi laptop...");

        Thread.Sleep(1500);
        
        Console.WriteLine("Done!");

        return new KiaomiLaptop();
    }

    public Netbook CreateNetbook()
    {
        Console.WriteLine("Creating a Kiaomi netbook...");

        Thread.Sleep(1500);
        
        Console.WriteLine("Done!");

        return new KiaomiNetbook();
    }

    public EBook CreateEBook()
    {
        Console.WriteLine("Creating a Kiaomi E-book...");

        Thread.Sleep(1500);
        
        Console.WriteLine("Done!");

        return new KiaomiEBook();
    }

    public Smartphone CreateSmartphone()
    {
        Console.WriteLine("Creating a Kiaomi smartphone...");

        Thread.Sleep(1500);
        
        Console.WriteLine("Done!");

        return new KiaomiSmartphone();
    }
}
