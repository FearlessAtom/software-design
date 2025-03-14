namespace Singleton;

public sealed class Authenticator
{
    static private Authenticator? Instance;
    static private object LockObject = new Object();

    private Authenticator()
    {
        Console.WriteLine("Creating an instance of a class...");
        Thread.Sleep(1500);
    }

    static public Authenticator GetIstance()
    {
        if (Instance == null)
        {
            lock(LockObject)
            {
                if (Instance == null)
                {
                    Instance = new Authenticator();
                }
            }
        }

        return Instance;
    }
}
