namespace Composite;

public class NoAttributeFormatter : IAttributeFormatter
{
    public string Format(Dictionary<string, string> AttributeDictionary, List<string> ClassList)
    {
        return "";
    }
}
