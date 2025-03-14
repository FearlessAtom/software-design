namespace Builder;

public class HeroBuilder : ICharacterBuilder
{
    private Character character = new Character();

    public HeroBuilder()
    {
        Reset();
    }

    private void Reset()
    {
        character = new Character();
    }

    public ICharacterBuilder SetName(string name)
    {
        character.Name = name;
        return this;
    }

    public ICharacterBuilder SetType(string type)
    {
        character.Type = type + " (Hero)";
        return this;
    }

    public ICharacterBuilder SetHeight(int height)
    {
        character.Height = height;
        return this;
    }

    public ICharacterBuilder SetHairColor(string color)
    {
        character.HairColor = color;
        return this;
    }

    public ICharacterBuilder SetEyeColor(string color)
    {
        character.EyeColor = color;
        return this;
    }

    public ICharacterBuilder SetClothes(string clothes)
    {
        character.Clothes = clothes;
        return this;
    }

    public ICharacterBuilder GiveItem(string item)
    {
        character.Inventory.Add(item);
        return this;
    }

    public ICharacterBuilder AddDeed(string deed)
    {
        character.Deeds.Add(deed);
        return this;
    }

    public Character GetCharacter()
    {
        Character result = character;
        Reset();
        return result;
    }
}
