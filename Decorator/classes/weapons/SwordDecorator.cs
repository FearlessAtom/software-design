namespace Decorator;

public class SwordDecorator : CharacterDecorator
{
    public SwordDecorator(ICharacter Wrappee) : base(Wrappee) {  }

    override public List<string> GetWeapons()
    {
        Wrappee.AddWeapons("Sword");
        return Wrappee.GetWeapons();
    }
}
