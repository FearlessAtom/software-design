namespace something;

public class WarehouseItem
{
    public IProduct Product { get; set; }
    public string Unit { get; set; }
    public int Quanity { get; set; }
    public DateTime LastRestock { get; set; }

    public WarehouseItem(IProduct Product, string Unit, int Quanity, DateTime? LastRestock = null)
    {
        this.Product = Product;
        this.Unit = Unit;
        this.Quanity = Quanity;
        this.LastRestock = LastRestock ?? DateTime.Now;
    }

    public string GetTotalCostDollarsString()
    {
        double Result = Product.Cost.ToDollars() * Quanity;

        return "$" + (Result).ToString().Replace(".", ",");
    }

    public string GetTotalCostString()
    {
        double Result = Product.Cost.Count.ToDouble() * Quanity;

        return Product.Cost.Currency.Symbol + (Result).ToString().Replace(".", ",");
    }
}
