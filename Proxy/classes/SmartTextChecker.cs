namespace Proxy;

public sealed class SmartTextChecker : Reader
{
    static private SmartTextChecker? Instance;
    static private object LockObject = new Object();

    private SmartTextReader SmartTextReader;

    private SmartTextChecker()
    {
        this.SmartTextReader = SmartTextReader.GetInstance();
    }

    override public char[][] Read(string FilePath)
    {
        if (!File.Exists(FilePath))
        {
            throw new FileNotFoundException($"File {FilePath} does not exist!");
        }

        Console.WriteLine($"File {FilePath} opened successfully!");

        char[][] Lines = new char[][] {};

        try
        {
            Lines = this.SmartTextReader.Read(FilePath);
        }

        catch (Exception Exception)
        {
            Console.WriteLine("Error reading the file!");
            Console.WriteLine(Exception.Message);
        }

        int LineCount = Lines.Count();

        int CharacterCount = 0;
        
        for (int i = 0; i < Lines.Count(); i++)
        {
            CharacterCount = CharacterCount + Lines[i].Count();
        }

        Console.WriteLine($"File {FilePath} is read successfully!");

        Console.WriteLine();

        Console.WriteLine("Total line count: " + LineCount);
        Console.WriteLine("Total character count: " + CharacterCount);

        return Lines;
    }

    static public SmartTextChecker GetInstance()
    {
        if (SmartTextChecker.Instance == null)
        {
            lock (SmartTextChecker.LockObject)
            {
                if (SmartTextChecker.Instance == null)
                {
                    SmartTextChecker.Instance = new SmartTextChecker();
                }
            }
        }

        return SmartTextChecker.Instance;
    }
}
