using System.Text;

namespace Prototype;

public class Virus : IVirusPrototype
{
    public string Name { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;

    public int Weight;
    public int Age;

    public List<Virus> Children = new List<Virus>();

    public Virus(string Name, string Type, int Weight = 0, int Age = 0, List<Virus>? Children = null)
    {
        this.Name = Name;
        this.Type = Type;
        this.Weight = Weight;
        this.Age = Age;
        this.Children = Children ?? new List<Virus>();
    }

    public Virus(Virus Virus)
    {
        this.Name = Virus.Name;
        this.Type = Virus.Type;
        this.Weight = Virus.Weight;
        this.Age = Virus.Age;

        for(int i = 0; i < Virus.Children.Count; i++)
        {
            this.Children.Add(Virus.Children[i].Clone());
        }
    }

    public Virus Clone()
    {
        return new Virus(this);
    }

    public string DisplayInfo(string Gap = "")
    {
        StringBuilder Output = new StringBuilder();

        Output.AppendLine($"{Gap}Virus information:");
        Output.AppendLine($"{Gap}Name: {this.Name}");
        Output.AppendLine($"{Gap}Type: {this.Type}");
        Output.AppendLine($"{Gap}Weight: {this.Weight}");
        Output.AppendLine($"{Gap}Age: {this.Age}");

        if (Children.Count != 0)
        {
            Output.AppendLine();
            Output.AppendLine($"Children:");
        }

        for (int i = 0; i < Children.Count; i++)
        {
            Output.AppendLine();
            Output.Append(Children[i].DisplayInfo(Gap + "  "));
        }

        return Output.ToString();
    }
}
