﻿// Compute the order of magnitude of an integer.
using System;
class WhileDemo
{
    static void Main()
    {
        int num;
        int mag;
        num = 435679;
        mag = 0;
        Console.WriteLine("Number: " + num);
        while (num > 0)
        {
            mag++;
            num = num / 10;
        };
        Console.WriteLine("Magnitude: " + mag);

        return;
    }
}