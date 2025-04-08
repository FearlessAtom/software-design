namespace Decorator;

public class Mage : Character
{
    public Mage(int Armor=5, int Damage=15)
    {
        this.Armor = Armor;
        this.Damage = Damage;
        this.Type = "Mage";

        this.Artifacts = new List<string>();
        this.Clothes = new List<string>();
        this.Weapons = new List<string>();
    }
}
