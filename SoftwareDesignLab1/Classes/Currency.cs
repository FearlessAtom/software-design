namespace something;

public class Currency
{
    public Currency() { }

    public Currency(string Symbol, string Code, double ToDollarRatio = 1)
    {
        this.Symbol = Symbol;
        this.Code = Code;
        this.ToDollarRatio = ToDollarRatio;
    }

    public string Symbol { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public double ToDollarRatio { get; set; }
}
