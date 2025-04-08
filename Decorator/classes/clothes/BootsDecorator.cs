namespace Decorator;

public class BootsDecorator : CharacterDecorator
{
    public BootsDecorator(ICharacter Wrappee) : base(Wrappee) {  }

    override public List<string> GetClothes()
    {
        Wrappee.AddClothes("Boots");
        return Wrappee.GetClothes();
    }
}
