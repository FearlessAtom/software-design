namespace AbstractFactory;

class KiaomiEBook : EBook
{
    public KiaomiEBook()
    {
        this.Type = "EBook";
        this.Model = "RedmiBook";
        this.Price = 90;
        this.Manifacturer = "Kiaomi";
        this.OperatingSystem = "Linux";
        this.ScreenSize = 10.0;
    }

    override public void ReadBook()
    {
        Console.WriteLine($"Reading a book on a {this.Model} {this.Type}...");
    }
}
