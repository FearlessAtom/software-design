namespace something;

public interface IDiscountable
{
    int Discount { get; set; }

    double ApplyDiscount();

    IProduct SetDiscount(int Discount);
}
