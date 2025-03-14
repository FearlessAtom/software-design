using System.Text;

namespace AbstractFactory;

public class Device
{
    public string Type { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public string Manufacturer { get; set; } = string.Empty;
    public double Price { get; set; }
    public string OperatingSystem { get; set; } = string.Empty;
    public double ScreenSize { get; set; }

    public void DisplayInfo()
    {
        StringBuilder Output = new StringBuilder().
            AppendLine("Device information:").
            AppendLine("Type: " + this.Type).
            AppendLine("Model: " + this.Model).
            AppendLine("Price: $" + this.Price).
            AppendLine("Manifacturer: " + this.Manufacturer).
            AppendLine("Screen size: " + this.ScreenSize + " " + (this.ScreenSize == 1 ? "inch" : "inches")).
            AppendLine("Operating system: " + this.OperatingSystem);

        Console.Write(Output.ToString());
    }
}
