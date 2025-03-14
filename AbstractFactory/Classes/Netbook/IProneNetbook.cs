namespace AbstractFactory;

class IProneNetbook : Netbook
{
    public IProneNetbook()
    {
        this.Type = "NetBook";
        this.Model = "INetBook";
        this.Price = 500;
        this.Manifacturer = "Apple";
        this.OperatingSystem = "MacOS";
        this.ScreenSize = 12.0;
    }

    override public void BrowseInternet()
    {
        Console.WriteLine($"Browsing the web on a {this.Model} {this.Type}...");
    }
}
