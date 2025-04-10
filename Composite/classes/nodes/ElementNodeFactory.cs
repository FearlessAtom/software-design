namespace Composite;

public class ElementNodeFactory
{
    static private Dictionary<string, ElementNodeType> ElementNodeTypes = new Dictionary<string, ElementNodeType>();

    public ElementNodeType GetElementNodeType(string TagName, string Display, TagFormatter TagFormatter)
    {
        string Id = TagName + Display + TagFormatter.GetType().FullName;
        
        if (!ElementNodeTypes.ContainsKey(Id))
        {
            ElementNodeTypes[Id] = new ElementNodeType(TagName, Display, TagFormatter);
        }

        return ElementNodeTypes[Id];
    }
}
