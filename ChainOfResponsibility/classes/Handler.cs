namespace ChainOfResponsibility;

abstract public class Handler : IHandler
{
    public IHandler? NextHandler = null;

    virtual public void SetNext(IHandler Handler)
    {
        if (Handler != null)
        {
            this.NextHandler = Handler;
            return;
        }
    }

    virtual public void HandleNext()
    {
        this.NextHandler?.Handle();
    }

    public bool Handle()
    {
        if (HandleRequest()) return true;

        return NextHandler?.Handle() ?? false;
    }

    public abstract bool HandleRequest();
}
