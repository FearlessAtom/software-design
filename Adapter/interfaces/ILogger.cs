namespace Adapter;

public interface ILogger
{
    void Log(string Content);
    void Warn(string Content);
    void Error(string Content);
}
