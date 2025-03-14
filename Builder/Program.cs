namespace Builder;

public class Program
{
    static void Main(string[] args)
    {
        HeroBuilder heroBuilder = new HeroBuilder();
        EnemyBuilder enemyBuilder = new EnemyBuilder();

        CharacterDirector director = new CharacterDirector();

        Character hero = director.CreateHero(heroBuilder);

        Character enemy = director.CreateEnemy(enemyBuilder);

        Console.WriteLine(hero);

        Console.WriteLine();

        Console.WriteLine(enemy);
    }
}
