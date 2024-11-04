using calculator.lib.Contracts;

namespace calculator.lib;

public class Division : IDivision
{
    public int Div(int a, int b)
    {
        return a/b;
    }
}