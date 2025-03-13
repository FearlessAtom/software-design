using System.Text;

namespace task1;

public class DomesticSubscription : ISubscription
{
    public double MonthlyFee { get; set; }
    public List<string> ChannelList { get; set; } = new List<string>();
    public TimeSpan MinimumSubscriptionPeriod { get; set; }
    public string Description { get; set; } = string.Empty;

    public DomesticSubscription()
    {
        TimeSpan Period = DateTime.Now.AddMonths(1).AddSeconds(1) - DateTime.Now;
        this.MinimumSubscriptionPeriod = Period;

        this.MonthlyFee = 10;

        this.ChannelList = new List<string>() { "NBC", "CBS", "ABC", "Fox", "MyNetworkTV", "The CW", "The CW Plus", "PBS",
            "Create", "World Channel" };

        StringBuilder Description = new StringBuilder().
            AppendLine("The domestic subscription is designed for everyday household entertainment.").
            AppendLine("Offering a curated selection of popular channels at an affordable price.");

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
