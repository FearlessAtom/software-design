namespace Composite;

public class LightTextNode : LightNode
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
