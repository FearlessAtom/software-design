namespace Composite;

abstract public class TagFormatter
{
    public IAttributeFormatter AttributeFormatter { get; set; }

    public TagFormatter(IAttributeFormatter? AttributeFormatter = null)
    {
        if (AttributeFormatter == null)
        {
            AttributeFormatter = new DefaultAttributeFormatter();
        }

        this.AttributeFormatter = AttributeFormatter;
    }

    abstract public string FormatOuter(LightElementNode Node, string Gap="");
    abstract public string FormatInner(LightElementNode Node, string Gap="");
}
