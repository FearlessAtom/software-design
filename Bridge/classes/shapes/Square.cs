namespace Bridge;

public class Square : Shape
{
    public Square(Graphics Graphics, string Name="Square") : base(Graphics, Name) { }

    override public void Draw()
    {
        Graphics.Render(Name);
    }
}
