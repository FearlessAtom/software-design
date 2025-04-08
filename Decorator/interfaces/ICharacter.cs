namespace Decorator;

public interface ICharacter
{
    int Armor { get; set; }
    int Damage { get; set; }
    string Type { get; set; }

    List<string> Clothes { get; set; }
    void AddClothes(string Clothes);
    List<string> GetClothes();

    List<string> Weapons { get; set; }
    void AddWeapons(string Weapons);
    List<string> GetWeapons();

    List<string> Artifacts { get; set; }
    void AddArtifact(string Artifact);
    List<string> GetArtifacts();

    int GetArmor();
    int GetDamage();

    void DisplayInfo();
}
