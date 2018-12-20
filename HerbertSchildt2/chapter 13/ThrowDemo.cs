// Manually throw an exception.
using System;
class ThrowDemo
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Before throw.");
            throw new DivideByZeroException();
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Exception caught.");
        }
        Console.WriteLine("After try/catch statement.");
    }
}