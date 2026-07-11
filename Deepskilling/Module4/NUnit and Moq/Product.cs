public class Product
{
    public int Quantity { get; private set; }

    public Product(int quantity)
    {
        Quantity = quantity;
    }

    public void AddStock(int count)
    {
        Quantity += count;
    }
}
