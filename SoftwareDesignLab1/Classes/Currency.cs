namespace something;

public class Currency : ICurrency
{
    public string Symbol { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    private double _ToDollarRatio { get; set; }

    public double ToDollarRatio
    {
        get
        {
            return this._ToDollarRatio;
        }
        
        set
        {
            if (value < 0)
            {
                throw new Exception("ToDollarRatio cannot be negative!");
            }

            this._ToDollarRatio = value;
        }
    }
}
