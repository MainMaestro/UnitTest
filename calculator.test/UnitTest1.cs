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
    public void DivisionText(){
        IDivision division = new Division();
        Assert.Equal(1, division.Div(2,2));
        Assert.Throws(typeof(DivideByZeroException),()=>{division.Div(2,0);});
    }
}