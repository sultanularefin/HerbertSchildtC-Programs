// Declare loop control variable inside the for.
using System;
class ForVar
{
    static void Main()
    {
        int sum = 0;
        int fact = 1;
        // Compute the factorial of the numbers 1 through 5.
        for (int i = 1; i <= 5; i++)
        {
            sum += i; // i is known throughout the loop.
            fact *= i;
        }
        // But, i is not known here.
        Console.WriteLine("Sum is " + sum);
        Console.WriteLine("Factorial is " + fact);

        return;
    }
}