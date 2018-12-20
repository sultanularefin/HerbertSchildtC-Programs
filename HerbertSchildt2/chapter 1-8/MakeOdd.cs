// Use bitwise OR to make a number odd.
using System;
class MakeOdd
{
    static void Main()
    {
        ushort num;
        ushort i;
        for (i = 1; i <= 10; i++)
        {
            num = i;
            Console.WriteLine("num: " + num);
            num = (ushort)(num | 1);
            Console.WriteLine("num after turning on bit zero: "
            + num + "\n");
        }
    }
}