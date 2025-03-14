namespace AbstractFactory;

class BalaxyNetbook : Netbook
{
    public BalaxyNetbook()
    {
        this.Type = "Netbook";
        this.Model = "BalaxyTab";
        this.Price = 450;
        this.Manifacturer = "Samsung";
        this.OperatingSystem = "Windows11";
        this.ScreenSize = 9.5;
    }

    override public void BrowseInternet()
    {
        Console.WriteLine($"Browsing the web on a {this.Model} {this.Type}...");
    }
}
