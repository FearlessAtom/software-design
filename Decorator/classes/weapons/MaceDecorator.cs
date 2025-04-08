namespace Decorator;

public class MaceDecorator : CharacterDecorator
{
    public MaceDecorator(ICharacter Wrappee) : base(Wrappee) {  }

    override public List<string> GetWeapons()
    {
        Wrappee.AddWeapons("Mace");
        return Wrappee.GetWeapons();
    }
}
