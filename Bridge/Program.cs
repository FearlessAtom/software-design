namespace Bridge;

public class Program
{
    static void Main(string[] args)
    {
        Graphics VectorGraphics = new VectorGraphics();
        Graphics RasterGraphics = new RasterGraphics();

        Shape Circle = new Circle(VectorGraphics);
        Shape Square = new Square(RasterGraphics);
        Shape Triangle = new Triangle(VectorGraphics);

        Circle.Draw();
        Square.Draw();
        Triangle.Draw();
    }
}
