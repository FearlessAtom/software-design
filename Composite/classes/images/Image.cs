namespace Composite;

public class Image : LightElementNode
{
    private IImageLoader? ImageLoader { get; set; }
    public string Href = string.Empty;

    public Image(): base("Image", new SelfClosingTagFormatter())
    {
        
    }

    public void SetHref(string Href)
    {
        this.Href = Href;
        this.AttributeDictionary["href"] = this.Href;

        if (this.Href.StartsWith("https://") || this.Href.StartsWith("http://"))
        {
            this.ImageLoader = new NetworkLoader();
        }

        else
        {
            this.ImageLoader = new FileSystemLoader();
        }
    }

    public string GetHref(string Href)
    {
        return this.Href;
    }

    public void LoadImage()
    {
        if (string.IsNullOrEmpty(this.Href))
        {
            throw new Exception("Href is not set!");
        }

        string Href = this.AttributeDictionary["href"];

        this.ImageLoader?.LoadImage(Href);
    }
}
