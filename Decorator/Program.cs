namespace Decorator;

class Program
{
    static void Main(string[] args)
    {
        CharacterDecorator Warrior = new BootsDecorator(new HelmetDecorator(new
            ChestplateDecorator(new MaceDecorator(new CharacterDecorator(new Warrior())))));

        CharacterDecorator Mage = new BlazewakeDecorator(new StoneheartDecorator(new
            CharacterDecorator(new Mage())));
        
        CharacterDecorator Paladin = new PowerhouseDecorator(new ChestplateDecorator(new
            CharacterDecorator(new Paladin())));

        Warrior.DisplayInfo();

        Console.WriteLine();

        Mage.DisplayInfo();

        Console.WriteLine();

        Paladin.DisplayInfo();
    }
}
