namespace Calc.Test2;

public class CalcTest
{
    private Calculator calc;
    public CalcTest()
    {
        calc = new();
    }

    [Fact]
    public void Add_CorrectAddition()
    {
        // Arrange
        int a = 1;
        int b = 2;
        int expected = 3;

        // Action
        int actual = calc.Add(1,2);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(1, 1, 2)]
    [InlineData(12, 1, 13)]
    [InlineData(-5, 5, 0)]
    public void Add_CorrectAddition_TestCase(int a, int b, int expected)
    {
        int actual = calc.Add(a, b);

        Assert.Equal(expected, actual);
    }
}