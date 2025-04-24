namespace Composite;

public class FileSystemLoader : IImageLoader
{
    public void LoadImage(string Href)
    {
        if (File.Exists(Href))
        {
            Console.WriteLine("Image was successfully loaded from the file system!");
        }

        else 
        {
            Console.WriteLine($"Image {Href} count not be found!");
        }
    }
}
