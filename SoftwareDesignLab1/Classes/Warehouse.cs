namespace something;

public class Warehouse
{
    public List<(string Unit, int Quanity, DateTime LastRestock)> Products = new List<(string, int, DateTime)>();
}
