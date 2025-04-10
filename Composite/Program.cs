namespace Composite;

class Program
{
    static void Main(string[] args)
    {
        LightElementNode form = new LightElementNode("form");

        LightElementNode title = new LightElementNode("h2");

        title.AppendChild(new LightTextNode("Sign in"));

        form.AppendChild(title);

        LightElementNode username= new LightElementNode("div");

        LightElementNode username_input = new LightElementNode("input", new SelfClosingTagFormatter());
        LightElementNode username_label = new LightElementNode("label");

        LightTextNode username_label_text = new LightTextNode("Username");
        username_label.AppendChild(username_label_text);

        username.AppendChild(username_input);
        username.AppendChild(username_label);

        form.AppendChild(username);
        
        LightElementNode password = new LightElementNode("div");

        LightElementNode password_input = new LightElementNode("input", new SelfClosingTagFormatter());
        LightElementNode password_label = new LightElementNode("label");

        LightTextNode password_label_text = new LightTextNode("Password");
        password_label.AppendChild(password_label_text);

        password.AppendChild(password_input);
        password.AppendChild(password_label);

        form.AppendChild(password);

        Console.Write(form.GetOuterHTML());
    }
}
