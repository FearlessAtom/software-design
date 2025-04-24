using System.Text;

namespace Memento;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        TextEditor TextEditor = new TextEditor();
        StringBuilder TextBuffer = new StringBuilder();
        ConsoleKeyInfo KeyInfo;

        while (true)
        {
            KeyInfo = Console.ReadKey(true);

            if (KeyInfo.Key == ConsoleKey.Escape)
            {
                break;
            }

            else if (KeyInfo.Key == ConsoleKey.Enter)
            {
                TextEditor.Write(TextBuffer.ToString());
                Redraw(TextEditor.GetContent(), TextBuffer);
            }

            else if (KeyInfo.Key == ConsoleKey.Z && KeyInfo.Modifiers.HasFlag(ConsoleModifiers.Control))
            {
                TextEditor.Undo();
                Redraw(TextEditor.GetContent(), TextBuffer);
            }

            else if (KeyInfo.Key == ConsoleKey.Backspace)
            {
                if (TextBuffer.Length > 0)
                {
                    TextBuffer.Remove(TextBuffer.Length - 1, 1);
                    Console.Write("\b \b");
                }
            }

            else
            {
                TextBuffer.Append(KeyInfo.KeyChar);
                Console.Write(KeyInfo.KeyChar);
            }
        }
    }

    static void Redraw(string Text, StringBuilder Buffer)
    {
        Buffer.Clear();
        Console.Clear();
        Console.WriteLine(Text);
    }
}
