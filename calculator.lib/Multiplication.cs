using calculator.lib.Contracts;

namespace calculator.lib;

public class Multiplication : IMultiplication
{
    public int Mul(int a, int b)
    {
        return a*b;
    }
}
