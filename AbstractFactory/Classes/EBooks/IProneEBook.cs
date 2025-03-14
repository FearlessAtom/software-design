namespace AbstractFactory;

class IProneEBook : EBook
{
    public IProneEBook()
    {
        this.Type = "EBook";
        this.Model = "IBook";
        this.Price = 300;
        this.Manufacturer = "Apple";
        this.OperatingSystem = "MacOS";
        this.ScreenSize = 12.0;
    }

    override public void ReadBook()
    {
        Console.WriteLine($"Reading a book on a {this.Model} {this.Type}...");
    }
}
