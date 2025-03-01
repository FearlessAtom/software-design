namespace something;

public class CurrencyDirector
{
    public Currency BuildHryvnias(ICurrencyBuilder Builder)
    {
        return Builder.SetCode("UAH").SetSymbol("₴").SetToDollarRatio(0.024).Build();
    }

    public Currency BuildEuros(ICurrencyBuilder Builder)
    {
        return Builder.SetCode("EUR").SetSymbol("€").SetToDollarRatio(1.04).Build();
    }

    public Currency BuildDollars(ICurrencyBuilder Builder)
    {
        return Builder.SetCode("USD").SetSymbol("$").SetToDollarRatio(1).Build();
    }

    public Currency BuildYen(ICurrencyBuilder Builder)
    {
        return Builder.SetCode("Yen").SetSymbol("¥").SetToDollarRatio(0.0066).Build();
    }

    public Currency BuildPounds(ICurrencyBuilder Builder)
    {
        return Builder.SetCode("GBP").SetSymbol("£").SetToDollarRatio(1.26).Build();
    }
}
