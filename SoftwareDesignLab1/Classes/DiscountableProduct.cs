namespace something;

public class DiscountableProduct : Product, IDiscountable
{
    public int Discount { get; set; }
    public DiscountableProduct(Money Cost, string Name) : base(Cost, Name) {}

    public double ApplyDiscount()
    {
        return (Cost.Count.ToDouble() / 100) * (100 - Discount);
    }

    public IProduct SetDiscount(int Discount)
    {
        this.Discount = Discount;
        return this;
    }
}
