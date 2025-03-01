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
                Items.ConvertAll(item => $"{item.Product.Name} - {item.Quanity} {item.Unit}, " +
                $"(Total cost: {item.GetTotalCostString()}) Last supply: {item.LastRestock}"));
    }

    public void AddProduct(WarehouseItem Item)
    {
        this.Items.Add(Item);
    }
}
