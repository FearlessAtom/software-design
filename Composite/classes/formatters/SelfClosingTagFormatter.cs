namespace Composite;

public class SelfClosingTagFormatter : TagFormatter
{
    public override string FormatOuter(LightElementNode Node, string Gap = "")
    {
        return Gap + $"<{Node.NodeType.TagName} />" + "\n";
    }

    public override string FormatInner(LightElementNode Node, string Gap = "")
    {
        return "";
    }
}
