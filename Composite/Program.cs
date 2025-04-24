namespace Composite;

class Program
{
    static void Main(string[] args)
    {
        LightElementNode ImageContainer = new LightElementNode("div");
        ImageContainer.ClassList.Add("container");

        Image FirstImage = new Image();
        FirstImage.SetHref("https://upload.wikimedia.org/wikipedia/commons/thumb/5/52/NAVI-Logo.svg/640px-NAVI-Logo.svg.png");
        FirstImage.LoadImage();
        FirstImage.ClassList.Add("image");
        ImageContainer.AppendChild(FirstImage);

        Image SecondImage = new Image();
        SecondImage.SetHref("./images/navi.png");
        SecondImage.LoadImage();
        SecondImage.ClassList.Add("image");
        ImageContainer.AppendChild(SecondImage);

        Console.WriteLine();

        Console.WriteLine(ImageContainer.GetOuterHTML());
    }
}
