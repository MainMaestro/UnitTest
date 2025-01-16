using calculator.lib;
using calculator.lib.Contracts;

namespace calculator.test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        ISummator summator = new Summator();
        Assert.Equal(4, summator.Sum(2, 2));
    }

    [Fact]
    public void DivisionText()
    {
        IDivision division = new Division();
        Assert.Equal(1, division.Div(2, 2));
        Assert.Throws(typeof(DivideByZeroException), () => { division.Div(2, 0); });
    }
    [Fact]
    public void Subtraction()
    {
        ISubtraction subtraction = new Subtraction();
        Assert.Equal(0, subtraction.Sub(2, 2));
    }
    [Fact]
    public void Multiplication()
    {
        IMultiplication multiplication = new Multiplication();
        Assert.Equal(16, multiplication.Mul(4, 4));
    }
}