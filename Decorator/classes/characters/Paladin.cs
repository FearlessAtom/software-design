namespace Decorator;

public class Paladin : Character
{
    public Paladin(int Armor=15, int Damage=5)
    {
        this.Armor = Armor;
        this.Damage = Damage;
        this.Type = "Paladin";

        this.Artifacts = new List<string>();
        this.Clothes = new List<string>();
        this.Weapons = new List<string>();
    }
}
