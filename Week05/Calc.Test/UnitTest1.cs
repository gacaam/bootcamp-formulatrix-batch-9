namespace Calc.Test;

public class CalculatorTests
{
    private Calculator calc;
    [SetUp]
    public void Setup()
    {
        calc = new();
    }

    [Test]
    public void Add_CorrectAddition()
    {
        // Arrange
        int a = 1;
        int b = 2;
        int expected = 3;

        // Action
        int actual = calc.Add(1,2);

        // Assert

        // Old model
        // Assert.AreEqual(expected, actual);

        // Constraint model
        Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase(1, 1, 2)]
    [TestCase(12, 1, 13)]
    [TestCase(-5, 5, 0)]
    public void Add_CorrectAddition_TestCase(int a, int b, int expected)
    {
        int actual = calc.Add(a, b);

        Assert.That(actual, Is.EqualTo(expected));
    }
}