namespace Adapter;

public class FileLoggerAdapter : ILogger
{
    private FileWriter FileWriter;

    public FileLoggerAdapter(FileWriter FileWriter)
    {
        this.FileWriter = FileWriter;
    }

    public void Log(string Content)
    {
        FileWriter.WriteLine("[Log] " + Content);
    }

    public void Warn(string Content)
    {
        FileWriter.WriteLine("[Warn] " + Content);
    }

    public void Error(string Content)
    {
        FileWriter.WriteLine("[Error] " + Content);
    }
}
