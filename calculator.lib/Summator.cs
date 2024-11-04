using calculator.lib.Contracts;

namespace calculator.lib;

public class Summator : ISummator
{
    public int Sum(int a, int b)
    {
        return a+b;
    }
}