using System.Text;

namespace Decorator;

public class CharacterDecorator : ICharacter
{
    public string Type { get; set; } = string.Empty;
    public int Armor { get; set; }
    public int Damage { get; set; }
    public List<string> Clothes { get; set; }
    public List<string> Weapons { get; set; }
    public List<string> Artifacts { get; set; }
    public ICharacter Wrappee { get; set; }

    public CharacterDecorator(ICharacter Wrappee)
    {
        this.Wrappee = Wrappee;
        this.Type = this.Wrappee.Type;

        this.Clothes = this.Wrappee.Clothes;
        this.Weapons = this.Wrappee.Weapons;
        this.Artifacts = this.Wrappee.Artifacts;
    }

    virtual public int GetDamage() => this.Wrappee.GetDamage();
    virtual public int GetArmor() => this.Wrappee.GetArmor();

    virtual public List<string> GetClothes() => this.Wrappee.GetClothes();
    virtual public void AddClothes(string Clothes)
    {
        this.Wrappee.AddClothes(Clothes);
    }

    virtual public List<string> GetWeapons() => this.Wrappee.GetWeapons();
    virtual public void AddWeapons(string Weapon)
    {
        this.Wrappee.AddWeapons(Weapon);
    }

    virtual public List<string> GetArtifacts() => this.Wrappee.GetArtifacts();
    virtual public void AddArtifact(string Artifact)
    {
        this.Wrappee.AddArtifact(Artifact);
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
