namespace Bridge;

public class Triangle : Shape
{
    public Triangle(Graphics Graphics, string Name="Triangle") : base (Graphics, Name) { }

    override public void Draw()
    {
        Graphics.Render(Name);
    }
}
