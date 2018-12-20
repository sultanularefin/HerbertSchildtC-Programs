// Demonstrate the shift << and >> operators.
using System;
class ShiftDemo
{
    static void Main()
    {
        int val = 1;

        for (int i = 0; i < 8; i++)
        {
            for (int t = 128; t > 0; t = t / 2)
            {
                if ((val & t) != 0) Console.Write("1 ");
                if ((val & t) == 0) Console.Write("0 ");
            }
            Console.WriteLine();
            val = val << 1; // left shift
        }
        Console.WriteLine();
        val = 128;
        for (int i = 0; i < 8; i++)
        {
            for (int t = 128; t > 0; t = t / 2)
            {
                if ((val & t) != 0) Console.Write("1 ");
                if ((val & t) == 0) Console.Write("0 ");
            }
            Console.WriteLine();
            val = val >> 1; // right shift
        }

        return;
    }
}