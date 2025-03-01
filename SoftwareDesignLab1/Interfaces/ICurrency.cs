namespace something;

public interface ICurrency
{
    string Symbol { get; set; }
    string Code { get; set; }
    double ToDollarRatio { get; set; }
}
