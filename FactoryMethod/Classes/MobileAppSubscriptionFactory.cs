namespace task1;

public class MobileAppSubscriptionFactory : SubscriptionFactory
{
    override public ISubscription CreateDomesticSubscription()
    {
        Console.WriteLine("Creating a domestic subscription via a mobile app...");

        Thread.Sleep(1500);

        Console.WriteLine("Domestic subscription was successfully created!");

        return new DomesticSubscription();
    }

    override public ISubscription CreatePremiumSubscription()
    {
        Console.WriteLine("Creating a premium subscription via a mobile app...");

        Thread.Sleep(1500);

        Console.WriteLine("Premium subscription was successfully created!");

        return new PremiumSubscription();
    }

    override public ISubscription CreateEducationalSubscription()
    {
        Console.WriteLine("Verifying an educational status...");

        Thread.Sleep(1500);

        Console.WriteLine("Creating an educational subscription via a mobile app...");

        Thread.Sleep(1500);

        Console.WriteLine("Educational subscription was successfully created!");

        return new EducationalSubscription();
    }
}
