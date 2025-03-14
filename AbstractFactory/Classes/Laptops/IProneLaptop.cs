namespace AbstractFactory;

class IProneLaptop : Laptop
{
    public IProneLaptop()
    {
        this.Type = "Laptop";
        this.Model = "MacBook";
        this.Price = 1201;
        this.Manifacturer = "Apple";
        this.OperatingSystem = "MacOS";
        this.ScreenSize = 15.3;
    }

    override public void DoWork()
    {
        Console.WriteLine($"Filling the blanks on a {this.Model} {this.Type}...");
    }
}
