namespace Adapter;

public class Logger : ILogger
{
    public void Log(string Content)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(Content);
        Console.ResetColor();
    } 

    public void Warn(string Content)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(Content);
        Console.ResetColor();
    } 

    public void Error(string Content)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(Content);
        Console.ResetColor();
    } 
}
