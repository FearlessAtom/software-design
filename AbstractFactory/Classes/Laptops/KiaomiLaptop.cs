namespace AbstractFactory;

class KiaomiLaptop : Laptop
{
    public KiaomiLaptop()
    {
        this.Type = "Laptop";
        this.Model = "RedmiBook";
        this.Price = 800;
        this.Manufacturer = "Kiaomi";
        this.OperatingSystem = "Windows 11";
        this.ScreenSize = 15.6;
    }

    override public void DoWork()
    {
        Console.WriteLine($"Filling the blanks on a {this.Model} {this.Type}...");
    }
}
