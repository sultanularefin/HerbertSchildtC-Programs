/*
Use the double type to compute the future value
of an investment.
*/
using System;
class FutVal
{

    static void Main()
    {
        double amount;
        double rate_of_return;
        int years, i;
        amount = 1000.0;
        rate_of_return = 0.07;
        years = 10;
        Console.WriteLine("Original investment: $" + amount);
        Console.WriteLine("Rate of return: " + rate_of_return);
        Console.WriteLine("Over " + years + " years");
        for (i = 0; i < years; i++)
            amount = amount + (amount * rate_of_return);
        Console.WriteLine("Future value is $" + amount);

        Console.WriteLine();
        Console.Write(sizeof(double)); // 8

        Console.WriteLine();

        Console.Write(sizeof(decimal)); //  16

        return;
    }
}