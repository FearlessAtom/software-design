using System.Text;

namespace Decorator;

public class Character : ICharacter
{
    public int Armor { get; set; }
    public int Damage { get; set; }
    public string Type { get; set; } = string.Empty;

    public List<string> Clothes { get; set; }
    public List<string> Weapons { get; set; }
    public List<string> Artifacts { get; set; }

    public Character(int Armor=0, int Damage=0)
    {
        this.Armor = Armor;
        this.Damage = Damage;
        this.Type = "Regular Character";

        this.Artifacts = new List<string>();
        this.Clothes = new List<string>();
        this.Weapons = new List<string>();
    }

    public int GetArmor() => this.Armor;
    public int GetDamage() => this.Damage;

    public List<string> GetClothes() => this.Clothes;
    public void AddClothes(string Clothes)
    {
        this.Clothes.Add(Clothes);
    }

    public List<string> GetWeapons() => this.Weapons;
    public void AddWeapons(string Clothes)
    {
        this.Weapons.Add(Clothes);
    }

    public List<string> GetArtifacts() => this.Artifacts;
    public void AddArtifact(string Artifact)
    {
        this.Artifacts.Add(Artifact);
    }

    virtual public void DisplayInfo()
    {
        List<string> Artifacts = GetArtifacts();
        List<string> Clothes = GetClothes();
        List<string> Weapons = GetWeapons();

        StringBuilder Output = new StringBuilder().
            AppendLine("Type: " + this.Type).
            AppendLine("Damage: " + GetDamage()).
            AppendLine("Armor: " + GetArmor());

        if (Weapons.Count != 0)
        {
            Output.Append("Weapons: ").
                AppendJoin(", ", Weapons);

            Output.AppendLine();
        }

        if (Clothes.Count != 0)
        {
            Output.Append("Clothes: ").
                AppendJoin(", ", Clothes);

            Output.AppendLine();
        }

        if (Artifacts.Count != 0)
        {
            Output.Append("Artifacts: ").
                AppendJoin(", ", Artifacts);

            Output.AppendLine();
        }

        Console.Write(Output.ToString());
    }
}
