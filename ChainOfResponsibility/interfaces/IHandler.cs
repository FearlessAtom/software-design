namespace ChainOfResponsibility;

public interface IHandler
{
    void SetNext(IHandler Handler);
    bool Handle();
}
