namespace Proxy;

public abstract class Reader
{
    abstract public char[][] Read(string FilePath);

    public void OutputCharacters(char[][] Lines)
    {
        for (int i = 0; i < Lines.Length; i++)
        {
            for (int j = 0; j < Lines[i].Length; j++)
            {
                Console.Write(Lines[i][j] + " ");
            }

            Console.WriteLine();
        }
    }
}
