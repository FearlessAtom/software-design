namespace something;

public class Product
{
    public string Name { get; set; } = string.Empty;
    public Money Cost { get; set; } = new Money();

    public Product(Money Cost)
    {
        this.Cost = Cost;
    }

    public void DecreaseCost(Money Money) {
        this.Cost = this.Cost - Money;
    }

    public void DecreaseCost(int WholePart, int FractionalPart)
    {
        Money Money = new Money(WholePart, FractionalPart);

        this.Cost = this.Cost - Money;
    }

    public void DecreaseCost(double Number)
    {
        Money Money = new Money(Number.ToNumber());

        this.Cost = this.Cost - Money;
    }
}
