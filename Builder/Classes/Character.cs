using System.Text;

namespace Builder;

public class Character
{
    public int Height { get; set; }
    public string Type { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string HairColor { get; set; } = string.Empty;
    public string EyeColor { get; set; } = string.Empty;
    public string Clothes { get; set; } = string.Empty;
    public List<string> Inventory { get; set; } = new List<string>();
    public List<string> Deeds { get; set; } = new List<string>();

    public override string ToString()
    {
        StringBuilder info = new StringBuilder()
            .AppendLine($"Character information:")
            .AppendLine($"Name: {this.Name}")
            .AppendLine($"Type: {this.Type}")
            .AppendLine($"Height: {this.Height} cm")
            .AppendLine($"Hair color: {this.HairColor}")
            .AppendLine($"Eye color: {this.EyeColor}")
            .AppendLine($"Clothes: {this.Clothes}")
            .AppendLine($"Inventory: {string.Join(", ", this.Inventory)}");

        if (Deeds.Count > 0)
        {
            info.AppendLine($"Deeds: {string.Join(", ", this.Deeds)}");
        }

        return info.ToString();
    }
}
