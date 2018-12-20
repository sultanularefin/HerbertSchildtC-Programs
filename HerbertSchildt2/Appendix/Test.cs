﻿// A documentation comment example.
using System;
/** <remark>
This is an example of multiline XML documentation.
The Test class demonstrates several tags.
</remark>
*/
class Test
{
    /// <summary>
    /// Main is where execution begins.
    /// </summary>
    static void Main()
    {
        int sum;
        sum = Summation(5);
        Console.WriteLine("Summation of " + 5 + " is " + sum);
    }
    /// <summary>
    /// Summation returns the summation of its argument.
    /// <param name = "val">
    /// The value to be summed is passed in val.
    /// </param>
    /// <see cref="int"> </see>
    /// <returns>
    /// The summation is returned as an int value.
    /// </returns>
    /// </summary>
    static int Summation(int val)
    {
        int result = 0;
        for (int i = 1; i <= val; i++)
            result += i;
        return result;
    }
}