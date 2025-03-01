namespace something;

public class Product : IProduct, IDiscountable
{
    public string Name { get; set; }
    public Money Cost { get; set; }
    public int Discount { get; set; }

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

    public double ApplyDiscount()
    {
        return (this.Cost.Count.ToDouble() / 100.0) * (100.0 - (double)Discount);
    }

    public IProduct SetDiscount(int Discount)
    {
        this.Discount = Discount;
        return this;
    }
}
