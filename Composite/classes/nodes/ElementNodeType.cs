namespace Composite;

public class ElementNodeType
{
    public string TagName { get; } = string.Empty;
    public string Display { get; } = string.Empty;
    public TagFormatter TagFormatter { get; }

    public ElementNodeType(string TagName, string Display, TagFormatter TagFormatter)
    {
        this.TagName = TagName;
        this.Display = Display;
        this.TagFormatter = TagFormatter;
    }
}
