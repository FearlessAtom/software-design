namespace Composite;

public class LightElementNode : LightNode
{
    static public string Gap = "   ";

    public List<LightNode> Children { get; set; }
    public List<string> ClassList { get; set; }

    public ElementNodeType NodeType { get; set; }

    public LightElementNode(string TagName="", TagFormatter? TagFormatter=null, string Display="block")
    {
        this.Children = new List<LightNode>();
        this.ClassList = new List<string>();

        if (TagFormatter == null)
        {
            TagFormatter = new OpenCloseTagFormatter();
        }

        this.NodeType = new ElementNodeFactory().GetElementNodeType(TagName, Display, TagFormatter);
    }

    override public string GetOuterHTML(string CurrentGap="")
    {
        return this.NodeType.TagFormatter.FormatOuter(this, CurrentGap);
    }

    override public string GetInnerHTML(string CurrentGap="")
    {
        return this.NodeType.TagFormatter.FormatInner(this, CurrentGap);
    }

    public void AppendChild(LightNode Child)
    {
        this.Children.Add(Child);
    }
}
