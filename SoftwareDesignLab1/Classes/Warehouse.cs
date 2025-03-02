namespace something;

public class Warehouse
{
    public List<WarehouseItem> Items = new List<WarehouseItem>();

    public Warehouse(List<WarehouseItem>? Items = null)
    {
        this.Items = Items ?? new List<WarehouseItem>();
    }

    public override string ToString()
    {
        return string.Join("\n",
            Items.ConvertAll(item => 
                $"{item.Product.Name} - {item.Quanity} {item.Unit}, " +
                $"(Total cost: {item.GetTotalCostString()}" +
                (item.Product is IDiscountable discountable && discountable.Discount != 0
                    ? $" (${(discountable.ApplyDiscount() * item.Quanity):F2})"
                    : "") + ")" +
                $" Last supply: {item.LastRestock}"
        ));
    }

    public void AddProduct(WarehouseItem Item)
    {
        this.Items.Add(Item);
    }
}
