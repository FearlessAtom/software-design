namespace something;

public class WarehouseItem
{
    public Product Product { get; set; }
    public string Unit { get; set; }
    public int Quanity { get; set; }
    public DateTime LastRestock { get; set; }

    public WarehouseItem(Product Product, string Unit, int Quanity, DateTime? LastRestock = null)
    {
        this.Product = Product;
        this.Unit = Unit;
        this.Quanity = Quanity;
        this.LastRestock = LastRestock ?? DateTime.Now;
    }

    public string GetTotalCostDollarsString()
    {
        return "$" + (Product.Cost.ToDollars() * Quanity).ToString().Replace(".", ",");
    }

    public string GetTotalCostString()
    {
        return Product.Cost.Currency.Symbol + (Product.Cost.Count.ToDouble() * Quanity).ToString().Replace(".", ",");
    }
}
