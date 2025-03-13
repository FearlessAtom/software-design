namespace task1;

static public class Utils
{
    public static string GetReadableTimeSpan(TimeSpan timeSpan)
    {
        TimeSpan difference = timeSpan.Duration();

        int years = (int)(difference.TotalDays / 365);
        int months = (int)((difference.TotalDays % 365) / 31);

        if (years > 0)
        {
            return $"{years} year{(years != 1 ? "s" : "")}";
        }

        if (months > 0)
        {
            return $"{months} month{(months != 1 ? "s" : "")}";
        }

        if (difference.Days > 0)
        {
            return $"{difference.Days} day{(difference.Days != 1 ? "s" : "")}";
        }

        else if (difference.Hours > 0)
        {
            return $"{difference.Hours} hour{(difference.Hours != 1 ? "s" : "")}";
        }

        else if (difference.Minutes > 0)
        {
            return $"{difference.Minutes} minute{(difference.Minutes != 1 ? "s" : "")}";
        }
        
        else if (difference.Seconds > 0)
        {
           return $"{difference.Seconds} second{(difference.Seconds != 1 ? "s" : "")}";
        }

        return "0 seconds";
    }
}
