namespace Bridge;

public class VectorGraphics : Graphics
{
    override public void Render(string ShapeName)
    {
        Console.WriteLine($"Drawing {ShapeName} as vectors.");
    }
}
