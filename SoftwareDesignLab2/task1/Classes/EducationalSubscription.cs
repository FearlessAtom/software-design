using System.Text;

namespace task1;

public class EducationalSubscription : ISubscription
{
    public double MonthlyFee { get; set; }
    public List<string> ChannelList { get; set; } = new List<string>();
    public TimeSpan MinimumSubscriptionPeriod { get; set; }
    public string Description { get; set; } = string.Empty;

    public EducationalSubscription()
    {
        TimeSpan Period = DateTime.Now.AddYears(1).AddSeconds(1) - DateTime.Now;
        this.MinimumSubscriptionPeriod = Period;

        this.MonthlyFee = 0;

        this.ChannelList = new List<string>() { "Discovery", "Animal Planet", "Science Channel", "The Learning Channel" };

        StringBuilder Description = new StringBuilder().
            AppendLine("An exclusive educational subscription designed for students and teachers.").
            AppendLine("Access to premium educational channels is provided free of charge for a period of one year.").
            AppendLine("To qualify for this subscription, confirming educational status is required.");

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
