using System.Text.RegularExpressions;

namespace Proxy;

public class SmartTextLocker : Reader
{
    public string RegularExpression;
    public SmartTextReader SmartTextReader;

    public SmartTextLocker(string RegularExpression="")
    {


        this.SmartTextReader = SmartTextReader.GetInstance();
        this.RegularExpression = RegularExpression;
    }

    override public char[][] Read(string FilePath)
    {
        if (!Regex.IsMatch(FilePath, this.RegularExpression))
        {
            Console.WriteLine("Access is denied!");
            return new char[][] { };
        }

        return this.SmartTextReader.Read(FilePath);
    }
}
