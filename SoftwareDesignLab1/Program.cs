namespace something;

public class Program
{
    static void Main(string[] args)
    {
        Number a = new Number(5, 50);
        Number b = new Number(5, 5);

        a = a - b;

        Console.WriteLine(a.WholePart + "," + a.FractionalPart);
    }
}
