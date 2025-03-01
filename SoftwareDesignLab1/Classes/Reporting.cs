namespace something;

public class Reporting
{
    public Warehouse Warehouse { get; set; }

    public Reporting(Warehouse Warehouse)
    {
        this.Warehouse = Warehouse;
    }

    public void InventoryReport()
    {
        Console.WriteLine(Warehouse.ToString());
    }

    public void RegisterArrival(WarehouseItem Item)
    {
        Warehouse.AddProduct(Item);
        Console.WriteLine($"Registered arrival of {Item.Quanity} {Item.Unit} of {Item.Product.Name}.");
    }

    public void GenerateShipmentInvoice(string Name, int Quanity)
    {
        foreach (var Item in Warehouse.Items)
        {
            if (Item.Product.Name == Name && Item.Quanity >= Quanity)
            {
                Console.WriteLine($"{Quanity} {Item.Unit} of {Name} shipped.");
                Item.Quanity = Item.Quanity - Quanity;
                return;
            }
        }

        Console.WriteLine($"Shipment Invoice could not be generated. Insufficient stock for {Name}.");
    }
}
