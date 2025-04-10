namespace Composite;

public class LightElementNode : LightNode
{
    static public string Gap = "   ";

    public string TagName { get; set; }
    public string Display { get; set; }

    public List<LightNode> Children { get; set; }
    public List<string> ClassList { get; set; }
    public TagFormatter TagFormatter { get; set; }

    public LightElementNode(string TagName="", TagFormatter? TagFormatter=null, string Display="block")
    {
        this.TagName = TagName;
        this.Display = Display;

        this.Children = new List<LightNode>();
        this.ClassList = new List<string>();

        if (TagFormatter == null)
        {
            TagFormatter = new OpenCloseTagFormatter();
        }

        this.TagFormatter = TagFormatter;
    }

    override public string GetOuterHTML(string CurrentGap="")
    {
        return this.TagFormatter.FormatOuter(this, CurrentGap);
    }

    override public string GetInnerHTML(string CurrentGap="")
    {
        return this.TagFormatter.FormatInner(this, CurrentGap);
    }

    public void AppendChild(LightNode Child)
    {
        this.Children.Add(Child);
    }
}
