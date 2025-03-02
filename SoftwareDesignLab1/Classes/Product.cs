namespace something;

public class Product : IProduct
{
    public string Name { get; set; }
    public Money Cost { get; set; }

    public Product(Money Cost, string Name)
    {
        this.Cost = Cost;
        this.Name = Name;
    }

    public void DecreaseCost(Money Money)
    {
        this.Cost = this.Cost - Money;
    }

    public void DecreaseCost(int WholePart, int FractionalPart)
    {
        Money Money = new Money(new Number(WholePart, FractionalPart));

        this.Cost = this.Cost - Money;
    }

    public void DecreaseCost(double Number)
    {
        Money Money = new Money(Number.ToNumber());

        if (Money.ToDollars() > this.Cost.ToDollars())
        {
            this.Cost.Count = (0.0).ToNumber();
            return;
        }

        this.Cost = this.Cost - Money;
    }
}
