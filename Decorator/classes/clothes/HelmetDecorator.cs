namespace Decorator;

public class HelmetDecorator : CharacterDecorator
{
    public HelmetDecorator(ICharacter Wrappee) : base(Wrappee) {  }

    override public List<string> GetClothes()
    {
        Wrappee.AddClothes("Helmet");
        return Wrappee.GetClothes();
    }
}
