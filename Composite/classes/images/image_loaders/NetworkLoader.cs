namespace Composite;

public class NetworkLoader : IImageLoader
{
    public void LoadImage(string Href)
    {
        try
        {
            HttpClient Client =  new HttpClient();

            HttpResponseMessage Response = Client.GetAsync(Href).Result;

            if (Response.IsSuccessStatusCode)
            {
                Console.WriteLine($"Image was successfully loaded from the network!");
            }

            else
            {
                Console.WriteLine($"Error loading the image! Status code: {Response.StatusCode}");
            }

            Client.Dispose();
        }

        catch (Exception Exception)
        {
            Console.WriteLine($"Could not load the image: {Href}, Error {Exception.Message}");
        }
    }
}
