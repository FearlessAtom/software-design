namespace something;

public class Program
{
    static void Main(string[] args)
    {
        CurrencyBuilder Builder = new CurrencyBuilder();
        CurrencyDirector Director = new CurrencyDirector();

        Currency Dollars = Director.BuildDollars(Builder);
        Currency Euros = Director.BuildEuros(Builder);
        Currency Yen = Director.BuildYen(Builder);
        Currency Pounds = Director.BuildPounds(Builder);
        Currency Hryvnias = Director.BuildHryvnias(Builder);

        Money a = new Money(new Number(200), Hryvnias);
        Money b = new Money(new Number(2), Dollars);

        a = a - b;

        a.Display();
        a.DisplayDollars();

        Product Product = new Product(a, "SomeProduct");
        Product.DecreaseCost(1);

        Product.Cost.Display();
        Product.Cost.DisplayDollars();

        Console.WriteLine();

        Warehouse Warehouse = new Warehouse();
        Reporting Reporting = new Reporting(Warehouse);

        Reporting.RegisterArrival(new WarehouseItem(new Product(new Money(new Number(3), Dollars), "Bread"),
                        "Loafs", 16, new DateTime(2024, 2, 15)));

        Reporting.RegisterArrival(new WarehouseItem(new Product(new Money(new Number(2), Dollars), "Water"),
                    "Half a gallon", 33, new DateTime(2024, 1, 10)));

        Reporting.RegisterArrival(new WarehouseItem(new Product(new Money(new Number(4), Dollars), "Milk"),
                    "Liters", 25, new DateTime(2024, 3, 5)));

        Reporting.RegisterArrival(new WarehouseItem(new Product(new Money(new Number(5), Euros), "Cheese"),
                    "Blocks", 20, new DateTime(2024, 2, 20)));

        Reporting.RegisterArrival(new WarehouseItem(new Product(new Money(new Number(6), Euros), "Butter"),
                    "Packs", 18, new DateTime(2024, 1, 25)));

        Reporting.RegisterArrival(new WarehouseItem(new Product(new Money(new Number(15), Euros), "Wine"),
                    "Bottles", 12, new DateTime(2024, 3, 1)));

        Reporting.RegisterArrival(new WarehouseItem(new Product(new Money(new Number(500), Yen), "Sushi"),
                    "Plates", 10, new DateTime(2024, 2, 5)));

        Reporting.RegisterArrival(new WarehouseItem(new Product(new Money(new Number(700), Yen), "Ramen"),
                    "Bowls", 15, new DateTime(2024, 1, 30)));

        Reporting.RegisterArrival(new WarehouseItem(new Product(new Money(new Number(300), Yen), "Green Tea"),
                    "Cups", 22, new DateTime(2024, 3, 10)));

        Reporting.RegisterArrival(new WarehouseItem(new Product(new Money(new Number(4), Pounds), "Tea"),
                    "Bags", 40, new DateTime(2024, 2, 28)));

        Reporting.RegisterArrival(new WarehouseItem(new Product(new Money(new Number(7), Pounds), "Biscuits"),
                    "Packs", 30, new DateTime(2024, 1, 12)));

        Reporting.RegisterArrival(new WarehouseItem(new Product(new Money(new Number(8), Pounds), "Coffee"),
                    "Jars", 28, new DateTime(2024, 3, 3)));

        Reporting.RegisterArrival(new WarehouseItem(new Product(new Money(new Number(35), Hryvnias), "Voda"),
                    "2 Liter", 50, new DateTime(2024, 2, 18)));

        Reporting.RegisterArrival(new WarehouseItem(new Product(new Money(new Number(50), Hryvnias), "Chocolate"),
                    "Bars", 35, new DateTime(2024, 1, 8)));

        Reporting.RegisterArrival(new WarehouseItem(new Product(new Money(new Number(60), Hryvnias), "Honey"),
                    "Jars", 25, new DateTime(2024, 3, 7)));

        Console.WriteLine();

        Reporting.InventoryReport();

        Console.WriteLine();

        Reporting.GenerateShipmentInvoice("Chocolate", 5);
    }
}
