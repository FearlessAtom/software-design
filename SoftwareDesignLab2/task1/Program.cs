using System.Text;

namespace task1;

class Program
{
    static void Main(string[] args)
    {
        SubscriptionFactory Factory;

        while(true)
        {
            StringBuilder FactoryPrompt = new StringBuilder().
                AppendLine("1) WebSite Subscription Factory").
                AppendLine("2) MobileApp Subscription Factory").
                AppendLine("3) ManagerCall Subscription Factory").
                Append("> ");

            Console.Write(FactoryPrompt);

            string Input = Console.ReadLine() ?? "";

            int Option;

            if (!int.TryParse(Input, out Option))
            {
                Console.WriteLine("Invalid input!");
                continue;
            }

            switch (Option)
            {
                case 1:
                {
                    Factory = new WebSiteSubscriptionFactory();
                    break;
                }

                case 2:
                {
                    Factory = new MobileAppSubscriptionFactory();
                    break;
                }

                case 3:
                {
                    Factory = new ManagerCallSubscriptionFactory();
                    break;
                }

                default:
                {
                    Console.WriteLine("Invalid option!");
                    continue;
                }
            }

            break;
        }

        ISubscription Subscription;

        while(true)
        {
            StringBuilder SubscriptionPrompt = new StringBuilder().
                AppendLine("1) Domestic Subscription").
                AppendLine("2) Premium Subscription").
                AppendLine("3) Educational Subscription").
                Append("> ");

            Console.Write(SubscriptionPrompt);

            string Input = Console.ReadLine() ?? "";

            int Option;

            if (!int.TryParse(Input, out Option))
            {
                Console.WriteLine("Invalid input!");
                continue;
            }

            switch (Option)
            {
                case 1:
                {
                    Subscription = Factory.CreateDomesticSubscription();
                    break;
                }

                case 2:
                {
                    Subscription = Factory.CreatePremiumSubscription();
                    break;
                }

                case 3:
                {
                    Subscription = Factory.CreateEducationalSubscription();
                    break;
                }

                default:
                {
                    Console.WriteLine("Invalid option!");
                    continue;
                }
            }

            break;
        }

        Console.WriteLine();
        Subscription.DisplayInfo();
    }
}
