namespace Adapter;

class Program
{
    static void Main(string[] args)
    {
        string FilePath = "./data.txt";

        FileWriter FileWriter = new FileWriter(FilePath, true);

        FileLoggerAdapter Adapter = new FileLoggerAdapter(FileWriter);

        Adapter.Log("This is a Log.");
        Adapter.Warn("This is a Warning!");
        Adapter.Error("This is an Error!!!");
    }
}
