// Boxing also occurs when passing values.
using System;
class BoxingDemo1
{
    static void Main()
    {
        int x;
        x = 10;
        Console.WriteLine("Here is x: " + x);
        // x is automatically boxed when passed to Sqr().
        x = BoxingDemo1.Sqr(x);
        Console.WriteLine("Here is x squared: " + x);
    }
    static int Sqr(object o)
    {
        return (int)o * (int)o;
    }
}