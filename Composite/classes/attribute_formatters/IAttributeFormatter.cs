namespace Composite;

public interface IAttributeFormatter
{
    public string Format(Dictionary<string, string> AttributeDictionary, List<string> ClassList);
}
