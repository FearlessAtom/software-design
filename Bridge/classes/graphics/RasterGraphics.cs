namespace Bridge;

public class RasterGraphics : Graphics
{
    override public void Render(string ShapeName)
    {
        Console.WriteLine($"Drawing {ShapeName} as pixels.");
    }
}
