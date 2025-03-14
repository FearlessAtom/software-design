namespace Singleton;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 5; i++)
        {
            (new Thread(() =>
            {
                 Authenticator Authenticator = Authenticator.GetIstance();
            })).Start();
        }

        Authenticator a = Authenticator.GetIstance();
        Authenticator b = Authenticator.GetIstance();

        Console.WriteLine();
        
        Console.WriteLine("Equality: " + (a == b ? "True" : "False"));
    }
}
