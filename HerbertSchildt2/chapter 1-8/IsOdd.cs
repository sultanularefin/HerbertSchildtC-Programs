// Use bitwise AND to determine if a number is odd.
using System;
class IsOdd
{
    static void Main()
    {
        ushort num;
        num = 10;
        if ((num & 1) == 1)
            Console.WriteLine("This won't display.");
        num = 11;
        if ((num & 1) == 1)
            Console.WriteLine(num + " is odd.");
    }
}