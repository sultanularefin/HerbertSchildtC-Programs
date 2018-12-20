﻿// Demonstrate an anonymous method that takes an argument.
using System;
// Notice that CountIt now has a parameter.
delegate void CountIt(int end);
class AnonMethDemo2
{
    static void Main()
    {
        // Here, the ending value for the count
        // is passed to the anonymous method.
        CountIt count = delegate(int end)
        {
            for (int i = 0; i <= end; i++)
                Console.WriteLine(i);
        };
        count(3);
        Console.WriteLine();
        count(5);
    }
}