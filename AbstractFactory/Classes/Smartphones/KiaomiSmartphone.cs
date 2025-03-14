namespace AbstractFactory;

class KiaomiSmartphone : Smartphone
{
    public KiaomiSmartphone()
    {
        this.Type = "Smartphone";
        this.Model = "POCO";
        this.Price = 390;
        this.Manifacturer = "Kiaomi";
        this.OperatingSystem = "Android";
        this.ScreenSize = 6.7;
    }
    
    override public void ScrollSocialMedia()
    {
        Console.WriteLine($"Scrolling social media on a {this.Model} {this.Type}...");
    }
}
