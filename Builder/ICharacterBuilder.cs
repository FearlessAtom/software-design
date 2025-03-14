namespace Builder;

public interface ICharacterBuilder
{
    ICharacterBuilder SetName(string name);
    ICharacterBuilder SetType(string type);
    ICharacterBuilder SetHairColor(string color);
    ICharacterBuilder SetEyeColor(string color);
    ICharacterBuilder SetClothes(string clothes);
    ICharacterBuilder SetHeight(int height);
    ICharacterBuilder GiveItem(string item);
    ICharacterBuilder AddDeed(string deed);
    Character GetCharacter();
}
