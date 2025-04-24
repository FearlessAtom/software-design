using System.Text;

namespace Composite;

public class DefaultAttributeFormatter : IAttributeFormatter
{
    public string Format(Dictionary<string, string> AttributeDictionary, List<string> ClassList)
    {
        StringBuilder Attributes = new StringBuilder();

        if (ClassList.Any())
        {
            Attributes.Append("class=\"")
                .AppendJoin(" ", ClassList)
                .Append("\"");
        }

        if (AttributeDictionary.Any())
        {
            Attributes.Append(" ");
        }

        Attributes.AppendJoin(" ", AttributeDictionary.
                Select(Attribute => Attribute.Key + "=\"" + Attribute.Value + "\""));

        return Attributes.ToString();
    }
}
