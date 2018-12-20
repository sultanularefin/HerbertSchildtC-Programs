// Demonstrate interface references.
using System;
// Define the interface.
public interface ISeries
{
    int GetNext(); // return next number in series
    void Reset(); // restart
    void SetStart(int x); // set starting value
}
// Use ISeries to implement a series in which each
// value is two greater than the previous one.
class ByTwos : ISeries
{
    int start;
    int val;

    public ByTwos()
    {
        start = 0;
        val = 0;
    }
    public int GetNext()
    {
        val += 2;
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
class SeriesDemo2
{
    static void Main()
    {
        ByTwos twoOb = new ByTwos();
        Primes primeOb = new Primes();
        ISeries ob;
        for (int i = 0; i < 5; i++)
        {
            ob = twoOb;
            Console.WriteLine("Next ByTwos value is " +
            ob.GetNext());
            ob = primeOb;
            Console.WriteLine("Next prime number is " +
            ob.GetNext());
        }
    }
}