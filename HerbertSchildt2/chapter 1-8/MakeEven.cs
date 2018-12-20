// Use bitwise AND to make a number even.
using System;
class MakeEven
{
    static void Main()
    {
        ushort num;
        ushort i;
        for (i = 1; i <= 10; i++)
        {
            num = i;
            Console.WriteLine("num: " + num);
            num = (ushort)(num & 0xFFFE);
            Console.WriteLine("num after turning off bit zero: "
            + num + "\n");
        }
    }
}