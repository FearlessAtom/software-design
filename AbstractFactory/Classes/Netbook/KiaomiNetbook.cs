namespace AbstractFactory;

class KiaomiNetbook : Netbook
{
    public KiaomiNetbook()
    {
        this.Type = "Netbook";
        this.Model = "Mi Air";
        this.Price = 500;
        this.Manufacturer = "Kiaomi";
        this.OperatingSystem = "Linux";
        this.ScreenSize = 14.0;
    }

    override public void BrowseInternet()
    {
        Console.WriteLine($"Browsing the web on a {this.Model} {this.Type}...");
    }
}
