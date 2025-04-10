using Composite;
using System.Diagnostics;

namespace FlyWeight;

class Program
{
    static void Main(string[] args)
    {
        string BookPath = "book.txt";

        string[] Lines = File.ReadAllLines(BookPath);

        LightElementNode Container = new LightElementNode("div");

        for (int i = 0; i < Lines.Count(); i++)
        {
            if (i == 0)
            {
                LightElementNode Title = new LightElementNode("h1");
                Title.AppendChild(new LightTextNode(Lines[i]));

                Container.AppendChild(Title);
            }

            else if (Lines[i].Count() != 0 && Lines[i][0] == ' ')
            {
                LightElementNode Title = new LightElementNode("blockquote");
                Title.AppendChild(new LightTextNode(Lines[i]));

                Container.AppendChild(Title);
            }

            else if (Lines[i].Count() < 20)
            {
                LightElementNode Title = new LightElementNode("h2");
                Title.AppendChild(new LightTextNode(Lines[i]));

                Container.AppendChild(Title);
            }

            else 
            {
                LightElementNode Title = new LightElementNode("p");
                Title.AppendChild(new LightTextNode(Lines[i]));

                Container.AppendChild(Title);
            }
        }
        
        //Console.WriteLine(Container.GetInnerHTML());
        
        Console.WriteLine(Process.GetCurrentProcess().WorkingSet64 / 1024 / 1024 + " MB");
    }
}
