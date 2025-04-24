namespace Composite;

public class SelfClosingTagFormatter : TagFormatter
{
    public override string FormatOuter(LightElementNode Node, string Gap = "")
    {
        string Attributes = this.AttributeFormatter.Format(Node.GetAttributes(), Node.ClassList);
 
        return Gap + $"<{Node.NodeType.TagName} {Attributes}{(Attributes != "" ? " " : "")}/>" + "\n";
    }

    public override string FormatInner(LightElementNode Node, string Gap = "")
    {
        return "";
    }
}
