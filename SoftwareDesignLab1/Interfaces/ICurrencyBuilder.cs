namespace something;

public interface ICurrencyBuilder
{
    ICurrencyBuilder SetCode(string Code);

    ICurrencyBuilder SetSymbol(string Symbol);

    ICurrencyBuilder SetToDollarRatio(double ToDollarRatio);

    Currency Build();
}
