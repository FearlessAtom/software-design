namespace Decorator;

public class Warrior : Character
{
    public Warrior(int Armor=10, int Damage=10)
    {
        this.Armor = Armor;
        this.Damage = Damage;
        this.Type = "Warrior";

        this.Artifacts = new List<string>();
        this.Clothes = new List<string>();
        this.Weapons = new List<string>();
    }
}
