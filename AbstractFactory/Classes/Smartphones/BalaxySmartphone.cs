namespace AbstractFactory;

class BalaxySmartphone : Smartphone
{
    public BalaxySmartphone()
    {
        this.Type = "Smartphone";
        this.Model = "Balaxy";
        this.Price = 400;
        this.Manifacturer = "Samsung";
        this.OperatingSystem = "Android";
        this.ScreenSize = 6.5;
    }
    
    override public void ScrollSocialMedia()
    {
        Console.WriteLine($"Scrolling social media on a {this.Model} {this.Type}...");
    }
}
