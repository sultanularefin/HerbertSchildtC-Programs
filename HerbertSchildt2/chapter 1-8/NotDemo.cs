// Demonstrate the bitwise NOT.
using System;
class NotDemo
{
    static void Main()
    {
        sbyte b = -34;
        for (int t = 128; t > 0; t = t / 2)
        {
            if ((b & t) != 0) Console.Write("1 ");
            if ((b & t) == 0) Console.Write("0 ");
        }
        Console.WriteLine();

        // reverse all bits
        b = (sbyte)~b;
        for (int t = 128; t > 0; t = t / 2)
        {
            if ((b & t) != 0) Console.Write("1 ");
            if ((b & t) == 0) Console.Write("0 ");
        }



        return;

    }
}