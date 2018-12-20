// Demonstrate the difference between prefix and
// postfix forms of ++.
using System;
class PrePostDemo
{
    static void Main()
    {
        int x, y;
        int i;
        x = 1;
        y = 0;
        Console.WriteLine("Series generated using y = y + x++;");
        for (i = 0; i < 10; i++)
        {
            y = y + x++; // postfix ++  // assignment operator evaluates right to left.
            Console.WriteLine(y + " ");
        }

        Console.WriteLine();
        x = 1;
        y = 0;
        Console.WriteLine("Series generated using y = y + ++x;");
        for (i = 0; i < 10; i++)
        {
            y = y + ++x; // prefix ++
            Console.WriteLine(y + " ");
        }
        Console.WriteLine();

        return;
    }
}