// *** This program will not compile. ***
using System;
class LtoD
{
    static void Main()
    {
        Console.WriteLine(sizeof(long));

        long L;
        double D;
        D = 100123285.0;
    //    L = D; // Illegal!!!
      //  Console.WriteLine("L and D: " + L + " " + D);

        return;
    }
}