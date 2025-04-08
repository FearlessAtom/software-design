namespace Decorator;

public class ChestplateDecorator : CharacterDecorator
{
    public ChestplateDecorator(ICharacter Wrappee) : base(Wrappee) {  }

    override public List<string> GetClothes()
    {
        Wrappee.AddClothes("Chestplate");
        return Wrappee.GetClothes();
    }
}
