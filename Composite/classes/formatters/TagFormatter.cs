namespace Composite;

abstract public class TagFormatter
{
    abstract public string FormatOuter(LightElementNode Node, string Gap="");
    abstract public string FormatInner(LightElementNode Node, string Gap="");
}
