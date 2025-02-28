using System.Globalization;

namespace something;

public class Money
{
    public Number Count { get; set; } = new Number();
    public Currency Currency { get; set; } = new Currency();

    public Money(int WholePart = 0, int FractionalPart = 0, string Symbol = "", string Code = "")
    {
        this.Count.SetWholePart(WholePart);
        this.Count.SetFractionalPart(FractionalPart);

        this.Currency.Symbol = Symbol;
        this.Currency.Code = Code;
    }

    public Money(Number Count, Currency Currency)
    {
        this.Count.SetWholePart(Count.WholePart);
        this.Count.SetFractionalPart(Count.FractionalPart);

        this.Currency.Symbol = Currency.Symbol;
        this.Currency.Code = Currency.Code;
    }

    public Money(Number Count)
    {
        
        this.Count.SetWholePart(Count.WholePart);
        this.Count.SetFractionalPart(Count.FractionalPart);
    }

    public void Display()
    {
        double Output = this.Count.ToDouble();

        string FormattedOutput = Output.ToString("N2", new CultureInfo("fr-FR"));

        Console.WriteLine(this.Currency.Symbol + FormattedOutput);
    }

    public static Money operator +(Money a, Money b)
    {
        a.Count = a.Count + b.Count;

        return a;
    }

    public static Money operator -(Money a, Money b)
    {
        a.Count = a.Count - b.Count;
        return a;
    }
}
