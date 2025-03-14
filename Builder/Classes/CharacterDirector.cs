namespace Builder;

public class CharacterDirector
{
    public Character CreateHero(ICharacterBuilder builder)
    {
        return builder
            .SetName("Legolas")
            .SetType("Elf Archer")
            .SetHeight(180)
            .SetHairColor("Blonde")
            .SetEyeColor("Blue")
            .SetClothes("Elven Cloak")
            .GiveItem("Bow")
            .GiveItem("Quiver of Arrows")
            .GiveItem("Elven Dagger")
            .AddDeed("Saved the village")
            .AddDeed("Defeated the dragon")
            .GetCharacter();
    }

    public Character CreateEnemy(ICharacterBuilder builder)
    {
        return builder
            .SetName("Uruk-hai")
            .SetType("Orc Warrior")
            .SetHeight(200)
            .SetHairColor("Black")
            .SetEyeColor("Red")
            .SetClothes("Leather Armor")
            .GiveItem("Club")
            .GiveItem("Shield")
            .AddDeed("Burned the town")
            .AddDeed("Destroyed the bridge")
            .GetCharacter();
    }
}
