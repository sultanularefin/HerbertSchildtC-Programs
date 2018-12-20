// Demonstrate the Obsolete attribute.
using System;
class Test1
{
    [Obsolete("Use MyMeth2, instead.")]
    public static int MyMeth(int a, int b)
    {
        return a / b;
    }
    // Improved version of MyMeth.
    public static int MyMeth2(int a, int b)
    {
        return b == 0 ? 0 : a / b;
    }
    static void Main()
    {
        // Warning displayed for this.
        Console.WriteLine("4 / 3 is " + Test1.MyMeth(4, 3));
        // No warning here.
        Console.WriteLine("4 / 3 is " + Test1.MyMeth2(4, 3));
    }
}