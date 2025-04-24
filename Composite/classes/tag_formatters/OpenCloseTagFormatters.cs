using System.Text;

namespace Composite;

public class OpenCloseTagFormatter : TagFormatter
{
    override public string FormatOuter(LightElementNode Node, string Gap="")
    {
        StringBuilder Result = new StringBuilder();

        string Attributes = this.AttributeFormatter.Format(Node.GetAttributes(), Node.ClassList);

        Result.Append($"{Gap}<{Node.NodeType.TagName}{(Attributes != "" ? " " :"")}{Attributes}>");

        if (Node.Children.Count != 0)
        {
            Result.AppendLine();
        }

        for (int i = 0; i < Node.Children.Count(); i++)
        {
            Result.Append(Node.Children[i].GetOuterHTML(Gap + LightElementNode.Gap));
        }

        Result.AppendLine($"{(Node.Children.Count == 0 ? "" : Gap)}<{Node.NodeType.TagName}/>");

        return Result.ToString();
    }

    override public string FormatInner(LightElementNode Node, string CurrentGap="")
    {
        StringBuilder Result = new StringBuilder();

        for (int i = 0; i < Node.Children.Count(); i++)
        {
            Result.Append(Node.Children[i].GetOuterHTML(CurrentGap + ""));
        }

        return Result.ToString();
    }
}

