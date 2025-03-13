namespace task1;

abstract public class SubscriptionFactory
{
    abstract public ISubscription CreateDomesticSubscription();

    abstract public ISubscription CreatePremiumSubscription();

    abstract public ISubscription CreateEducationalSubscription();
}
