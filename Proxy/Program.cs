namespace Proxy;

class Program
{
    static void Main(string[] args)
    {
        string FilePath = "./data.txt";

        Reader Checker = SmartTextChecker.GetInstance();

        char[][] CheckerLines = Checker.Read(FilePath);

        Console.WriteLine();

        Checker.OutputCharacters(CheckerLines);

        Console.WriteLine();

        Reader Locker = new SmartTextLocker("data.*");

        char[][] Lines = Locker.Read(FilePath);

        Locker.OutputCharacters(Lines);

        Console.WriteLine();

        Locker.Read("idk.txt");
    }
}
