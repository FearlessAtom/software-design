using System.Globalization;

namespace something;

public class Money
{
    public Number Count { get; set; } = new Number();
    public ICurrency Currency { get; set; }

    public Money(Number Count, ICurrency Currency)
    {
        this.Count.SetWholePart(Count.WholePart);
        this.Count.SetFractionalPart(Count.FractionalPart);

        this.Currency = Currency;
    }

    public Money(Number Count)
    {
        this.Count.SetWholePart(Count.WholePart);
        this.Count.SetFractionalPart(Count.FractionalPart);

        this.Currency = new CurrencyDirector().BuildDollars(new CurrencyBuilder());
    }

    public void Display()
    {
        double Output = this.Count.ToDouble();
        string FormattedOutput = Output.ToString("N2", new CultureInfo("fr-FR"));

        Console.WriteLine(this.Currency.Symbol + FormattedOutput);
    }

    public void DisplayDollars()
    {
        double Output = this.Count.ToDouble() * this.Currency.ToDollarRatio;
        string FormattedOutput = Output.ToString("N2", new CultureInfo("fr-FR"));

        Console.WriteLine("$" + FormattedOutput);
    }

    public double ToDollars()
    {
        return this.Count.ToDouble() * this.Currency.ToDollarRatio;
    }

    public static Money operator +(Money a, Money b)
    {
        double a_dollars = a.ToDollars();
        double b_dollars = b.ToDollars();

        a.Count = (((a_dollars + b_dollars) / a.Currency.ToDollarRatio)).ToNumber();

        return a;
    }

    public static Money operator -(Money a, Money b)
    {
        double a_dollars = a.ToDollars();
        double b_dollars = b.ToDollars();

        a.Count = (((a_dollars - b_dollars) / a.Currency.ToDollarRatio)).ToNumber();

        return a;
    }

    public static Money operator *(Money a, double b)
    {
        double a_dollars = a.ToDollars();

        a.Count = (a_dollars * b).ToNumber();

        return a;
    }

    public static Money operator /(Money a, double b)
    {
        double a_dollars = a.ToDollars();

        a.Count = (a_dollars / b).ToNumber();

        return a;
    }
}
