// Divide by only even, non-zero values.
using System;
class NoZeroDiv2
{
    static void Main()
    {
        int res=5;

        for ( int i = -5; i < 6; i++)
            if (i != 0 ? (i % 2 == 0) : false)
                Console.WriteLine("100 / " + i + " is " + 100 / i);

        Console.WriteLine(res);
        Console.Write(typeof(int));

        return;

    }

}