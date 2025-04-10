using System.Text;

namespace Composite;

public enum TagClosingStyle
{
    StartEnd,
    SelfClosing,
}

class Program
{
    static void Main(string[] args)
    {
        LightElementNode form = new LightElementNode("form");

        LightElementNode title = new LightElementNode("h2");

        title.AppendChild(new LightTextNode("Sign in"));

        form.AppendChild(title);

        LightElementNode username= new LightElementNode("div");

        LightElementNode username_input = new LightElementNode("input");
        LightElementNode username_label = new LightElementNode("label");

        LightTextNode username_label_text = new LightTextNode("Username");
        username_label.AppendChild(username_label_text);

        username.AppendChild(username_input);
        username.AppendChild(username_label);

        form.AppendChild(username);
        
        LightElementNode password = new LightElementNode("div");

        LightElementNode password_input = new LightElementNode("input");
        LightElementNode password_label = new LightElementNode("label");

        LightTextNode password_label_text = new LightTextNode("Password");
        password_label.AppendChild(password_label_text);

        password.AppendChild(password_input);
        password.AppendChild(password_label);

        form.AppendChild(password);

        Console.WriteLine(form.GetOuterHTML());
    }
}

abstract class LightNode
{

    abstract public string GetOuterHTML(string Gap="");
    abstract public string GetInnerHTML(string Gap="");
}

class LightElementNode : LightNode
{
    static public string GapIndent = "   ";

    public string TagName { get; set; }
    public string Display { get; set; }
    public TagClosingStyle ClosingStyle {get; set; }

    public List<LightNode> Children { get; set; }
    public List<string> ClassList { get; set; }

    override public string GetOuterHTML(string Gap="")
    {
        StringBuilder Result = new StringBuilder();

        Result.Append($"{Gap}<{this.TagName}>");

        if (this.Children.Count != 0)
        {
            Result.AppendLine();
        }

        for (int i = 0; i < Children.Count(); i++)
        {
            Result.Append(Children[i].GetOuterHTML(Gap + GapIndent));
        }


        Result.AppendLine($"{(Children.Count == 0 ? "" : Gap)}<{this.TagName}/>");

        return Result.ToString();
    }

    override public string GetInnerHTML(string Gap="")
    {
        return "Atom";
    }

    public LightElementNode(string TagName="", string Display="block")
    {
        this.TagName = TagName;
        this.Display = Display;

        this.Children = new List<LightNode>();
        this.ClassList = new List<string>();
    }

    public void AppendChild(LightNode Child)
    {
        this.Children.Add(Child);
    }
}

class LightTextNode : LightNode
{
    public string Text { get; set; }

    public LightTextNode(string Text="")
    {
        this.Text = Text;
    }

    public override string GetOuterHTML(string Gap = "")
    {
        return Gap + this.Text + "\n";
    }

    public override string GetInnerHTML(string Gap = "")
    {
        return Gap + "\n";
    }
}
