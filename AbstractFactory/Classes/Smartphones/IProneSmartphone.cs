namespace AbstractFactory;

class IProneSmartphone : Smartphone
{
    public IProneSmartphone()
    {
        this.Type = "Smartphone";
        this.Model = "IProne";
        this.Price = 1000;
        this.Manufacturer = "Apple";
        this.OperatingSystem = "IOS";
        this.ScreenSize = 6.1;
    }
    
    override public void ScrollSocialMedia()
    {
        Console.WriteLine($"Scrolling social media on a {this.Model} {this.Type}...");
    }
}
