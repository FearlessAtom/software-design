namespace Prototype;

class Program
{
    static void Main(string[] args)
    {
        Virus GrandParent = new Virus("s1mple", "Sniper", 85, 26);

        Virus Parent1 = new Virus("electron1c", "Rifler", 80, 24);
        Virus Parent2 = new Virus("Boombl4", "IGL", 100, 23);

        Virus Child1 = new Virus("b1t", "Rifler", 75, 21);
        Virus Child2 = new Virus("jL", "Rifler", 80, 14);
        Virus Child3 = new Virus("w0nderful", "Sniper", 40, 20);

        GrandParent.Children.Add(Parent1);
        GrandParent.Children.Add(Parent2);

        Parent1.Children.Add(Child1);
        Parent2.Children.Add(Child2);
        Parent2.Children.Add(Child3);

        Console.WriteLine("Virus family tree");
        Console.WriteLine();

        Console.Write(GrandParent.DisplayInfo());

        Console.WriteLine();
        Console.WriteLine("Copied virus family tree");
        Console.WriteLine();

        Console.Write(GrandParent.DisplayInfo());
    }
}
