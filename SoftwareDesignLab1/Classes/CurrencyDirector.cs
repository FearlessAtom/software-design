namespace something;

public class CurrencyDirector
{
    public ICurrency BuildHryvnias(ICurrencyBuilder Builder)
    {
        return Builder.SetCode("UAH").SetSymbol("₴").SetToDollarRatio(0.024).Build();
    }

    public ICurrency BuildEuros(ICurrencyBuilder Builder)
    {
        return Builder.SetCode("EUR").SetSymbol("€").SetToDollarRatio(1.04).Build();
    }

    public ICurrency BuildDollars(ICurrencyBuilder Builder)
    {
        return Builder.SetCode("USD").SetSymbol("$").SetToDollarRatio(1).Build();
    }

    public ICurrency BuildYen(ICurrencyBuilder Builder)
    {
        return Builder.SetCode("Yen").SetSymbol("¥").SetToDollarRatio(0.0066).Build();
    }

    public ICurrency BuildPounds(ICurrencyBuilder Builder)
    {
        return Builder.SetCode("GBP").SetSymbol("£").SetToDollarRatio(1.26).Build();
    }
}
