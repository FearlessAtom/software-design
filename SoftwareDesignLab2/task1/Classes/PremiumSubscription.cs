using System.Text;

namespace task1;

public class PremiumSubscription : ISubscription
{
    public double MonthlyFee { get; set; }
    public List<string> ChannelList { get; set; } = new List<string>();
    public TimeSpan MinimumSubscriptionPeriod { get; set; }
    public string Description { get; set; } = string.Empty;

    public PremiumSubscription()
    {
        TimeSpan Period = DateTime.Now.AddMonths(1).AddSeconds(1) - DateTime.Now;
        this.MinimumSubscriptionPeriod = Period;

        this.MonthlyFee = 20;

        this.ChannelList = new List<string>() { "NBC", "CBS", "ABC", "Fox", "MyNetworkTV", "The CW", "The CW Plus", "PBS",
            "Create", "World Channel", "Classic Arts Showcase", "First Nations Experience", "France 24", "MeTV",
            "Story Television", "Catchy Comedy", "Fave TV", "Movies!", "True Crime Network", "Grit" };

        StringBuilder Description = new StringBuilder().
            AppendLine("The premium subscription offers an extensive selection of channels.").
            AppendLine("Including a wider variety of content compared to the domestic subscription. ").
            AppendLine("Subscribers enjoy access to exclusive premium channels and ad-free viewing");

        this.Description = Description.ToString();
    }

    public void DisplayInfo()
    {
        StringBuilder Output = new StringBuilder().
            AppendLine("Premium subscription information:").
            AppendLine("Monthly fee: " + "$"+ this.MonthlyFee).
            AppendLine("Minimum subscription period: " + Utils.GetReadableTimeSpan(this.MinimumSubscriptionPeriod)).
            AppendLine("Number of channels: " + this.ChannelList.Count).
            AppendLine().
            AppendLine("Description:").
            Append(this.Description);

        Console.Write(Output.ToString());
    }
}
