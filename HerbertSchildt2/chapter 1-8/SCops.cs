// Demonstrate the short-circuit operators.
using System;
class SCops
{
    static void Main()
    {
        int n, d;
        n = 10;
        d = 2;
        if (d != 0 && (n % d) == 0) // (d != 0 is true && true) thus executes.
            Console.WriteLine(d + " is a factor of " + n);
        d = 0; // now, set d to zero
        // Since d is zero, the second operand is not evaluated.
        if (d != 0 && (n % d) == 0)     //d == 0 thus false , if (false && .... ) means false,  thus won't execute
            Console.WriteLine(d + " is a factor of " + n);
        // Now, try the same thing without the short-circuit operator.
        // This will cause a divide-by-zero error.
        if (d != 0 & (n % d) == 0)
            Console.WriteLine(d + " is a factor of " + n);

        return;
    }
}