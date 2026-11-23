using Calculator;

namespace Calculator.Tests;

public class CalculatorTests
{
    private readonly CalculatorService _calculator = new();

    [Fact]
    public void Add_ShouldReturnSum()
    {
        var result = _calculator.Add(10, 5);

        Assert.Equal(15, result);
    }

    [Fact]
    public void Subtract_ShouldReturnDifference()
    {
        var result = _calculator.Subtract(10, 5);

        Assert.Equal(5, result);
    }

    [Fact]
    public void Multiply_ShouldReturnProduct()
    {
        var result = _calculator.Multiply(10, 5);

        Assert.Equal(50, result);
    }
}