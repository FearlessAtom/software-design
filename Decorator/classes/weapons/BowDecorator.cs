namespace Decorator;

public class BowDecorator : CharacterDecorator
{
    public BowDecorator(ICharacter Wrappee) : base(Wrappee) {  }

    override public List<string> GetWeapons()
    {
        Wrappee.AddWeapons("Bow");
        return Wrappee.GetWeapons();
    }
}
