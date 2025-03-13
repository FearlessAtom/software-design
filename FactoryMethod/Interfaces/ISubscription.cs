namespace task1;

public interface ISubscription
{
    double MonthlyFee { get; set; }

    TimeSpan MinimumSubscriptionPeriod { get; set; }
    
    List<string> ChannelList { get; set; }

    string Description { get; set; }

    void DisplayInfo();
}
