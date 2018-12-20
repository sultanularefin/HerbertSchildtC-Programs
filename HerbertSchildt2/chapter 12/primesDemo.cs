﻿// Demonstrate the ISeries interface.
using System;
class primesDemo
{
    static void Main()
    {
        Primes ob = new Primes();
        for (int i = 0; i < 10; i++)
            Console.WriteLine("Next value is " +
            ob.GetNext());
        Console.WriteLine("\nResetting");
        ob.Reset();
        for (int i = 0; i < 5; i++)
            Console.WriteLine("Next value is " +
            ob.GetNext());

        Console.WriteLine("\nStarting at 100");
        ob.SetStart(100);
        for (int i = 0; i < 5; i++)
            Console.WriteLine("Next value is " +
            ob.GetNext());
    }
}

// Use ISeries to implement a series of prime numbers.
class Primes : ISeries
{
    int start;
    int val;
    public Primes()
    {
        start = 2;
        val = 2;
    }
    public int GetNext()
    {
        int i, j;
        bool isprime;
        val++;
        for (i = val; i < 1000000; i++)
        {
            isprime = true;
            for (j = 2; j <= i / j; j++)
            {
                if ((i % j) == 0)
                {
                    isprime = false;
                    break;
                }
            }

            if (isprime)
            {
                val = i;
                break;
            }
        }
        return val;
    }
    public void Reset()
    {
        val = start;
    }
    public void SetStart(int x)
    {
        start = x;
        val = start;
    }
}

public interface ISeries
{
    int GetNext(); // return next number in series
    void Reset(); // restart
    void SetStart(int x); // set starting value
}