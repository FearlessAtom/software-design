namespace Bridge;

public class Circle : Shape
{
    public Circle(Graphics Graphics, string Name="Circle") : base(Graphics, Name) { }

    override public void Draw()
    {
        Graphics.Render(Name);
    }
}

