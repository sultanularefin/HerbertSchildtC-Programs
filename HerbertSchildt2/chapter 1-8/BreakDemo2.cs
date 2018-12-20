// Using break to exit a do-while loop.
using System;
class BreakDemo2
{
    static void Main()
    {
        int i;
        i = -10;
        do
        {
            if (i > 0) break;
            Console.Write(i + " ");
            i++;
        } while (i <= 10);
        Console.WriteLine("Done");
    }
}