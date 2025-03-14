namespace AbstractFactory;

class BalaxyLaptop : Laptop
{
    public BalaxyLaptop()
    {
        this.Type = "Laptop";
        this.Model = "BalaxyBook";
        this.Price = 800;
        this.Manufacturer = "Samsung";
        this.OperatingSystem = "Windows 11";
        this.ScreenSize = 16;
    }

    override public void DoWork()
    {
        Console.WriteLine($"Filling the blanks on a {this.Model} {this.Type}...");
    }
}
