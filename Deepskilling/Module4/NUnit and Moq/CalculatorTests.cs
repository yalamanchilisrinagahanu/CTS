using NUnit.Framework;

[TestFixture]
public class CalculatorTests
{
    [Test]
    public void Add_TwoNumbers_ReturnsSum()
    {
        Calculator calculator = new Calculator();

        int result = calculator.Add(10, 20);

        Assert.AreEqual(30, result);
    }
}
