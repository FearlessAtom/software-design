namespace Composite;

abstract public class LightNode : EventListener
{
    abstract public string GetOuterHTML(string Gap="");
    abstract public string GetInnerHTML(string Gap="");
}
