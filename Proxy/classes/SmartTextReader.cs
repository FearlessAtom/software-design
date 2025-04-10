namespace Proxy;

public sealed class SmartTextReader : Reader
{
    static private SmartTextReader? Instance;
    static private Object LockObject = new Object();

    private SmartTextReader() {  }

    override public char[][] Read(string FilePath)
    {
        List<char[]> Lines = new List<char[]>();

        foreach (string Line in File.ReadAllLines(FilePath))
        {
            Lines.Add(Line.ToCharArray());
        }

        return Lines.ToArray();
    }

    static public SmartTextReader GetInstance()
    {
        if (SmartTextReader.Instance == null)
        {
            lock (SmartTextReader.LockObject)
            {
                if (SmartTextReader.Instance == null)
                {
                    SmartTextReader.Instance = new SmartTextReader();
                }
            }
        }

        return SmartTextReader.Instance;
    }
}
