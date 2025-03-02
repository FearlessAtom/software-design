namespace something;

public class CurrencyBuilder : ICurrencyBuilder
{
    private ICurrency _Currency = new Currency();


    public ICurrencyBuilder SetCode(string Code)
    {
        this._Currency.Code = Code;
        return this;
    }

    public ICurrencyBuilder SetSymbol(string Symbol)
    {
        this._Currency.Symbol = Symbol;
        return this;
    }

    public ICurrencyBuilder SetToDollarRatio(double ToDollarRatio)
    {
        this._Currency.ToDollarRatio = ToDollarRatio;
        return this;
    }

    public ICurrency Build()
    {
        ICurrency Currency = this._Currency;

        this._Currency = new Currency();

        return Currency;
    }
}
