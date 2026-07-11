using NUnit.Framework;

[TestFixture]
public class ProductTests
{
    [Test]
    public void AddStock_UpdatesQuantity()
    {
        Product product =
            new Product(10);

        product.AddStock(5);

        Assert.AreEqual(
            15,
            product.Quantity
        );
    }
}
