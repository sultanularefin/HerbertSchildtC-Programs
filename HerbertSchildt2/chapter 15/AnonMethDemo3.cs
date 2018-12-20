﻿// Demonstrate an anonymous method that returns a value.
using System;
// This delegate returns a value.
delegate int CountIt(int end);
class AnonMethDemo3
{
    static void Main()
    {
        int result;
        // Here, the ending value for the count
        // is passed to the anonymous method.
        // A summation of the count is returned.
        CountIt count = delegate(int end)
        {
            int sum = 0;
            for (int i = 0; i <= end; i++)
            {
                Console.WriteLine(i);
                sum += i;
            }
            return sum; // return a value from an anonymous method
        };
        result = count(3);
        Console.WriteLine("Summation of 3 is " + result);
        Console.WriteLine();
        result = count(5);
        Console.WriteLine("Summation of 5 is " + result);
    }
}