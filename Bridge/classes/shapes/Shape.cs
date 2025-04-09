namespace Bridge;

abstract public class Shape
{
    public string Name { get; set; }
    public Graphics Graphics { get; set; }

    public Shape(Graphics Graphics, string Name)
    {
        this.Name = Name;
        this.Graphics = Graphics;
    }

    abstract public void Draw();
}
