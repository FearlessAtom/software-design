namespace AbstractFactory;

class BalaxyEBook : EBook
{
    public BalaxyEBook()
    {
        this.Type = "EBook";
        this.Model = "BalaxyEBook";
        this.Price = 100;
        this.Manufacturer = "Samsung";
        this.OperatingSystem = "Linux";
        this.ScreenSize = 10.0;
    }

    override public void ReadBook()
    {
        Console.WriteLine($"Reading a book on a {this.Model} {this.Type}...");
    }
}
