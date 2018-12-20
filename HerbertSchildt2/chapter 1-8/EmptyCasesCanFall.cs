// Empty cases can fall through.
using System;
class EmptyCasesCanFall
{
    static void Main()
    {
        int i;
        for (i = 1; i < 5; i++)
            switch (i)
            {
                case 1: Console.WriteLine(1);
                    break;
                case 2: Console.WriteLine(2);
                    bre
                case 3: Console.WriteLine("i is 1, 2 or 3");
                    break;
                case 4: Console.WriteLine("i is 4");
                    break;
            }


        return;
    }
}