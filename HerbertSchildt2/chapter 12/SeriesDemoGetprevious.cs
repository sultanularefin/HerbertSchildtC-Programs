// Demonstrate the ISeries interface.
using System;
class SeriesDemoGetprevious
{
    static void Main()
    {
        ByTwos ob = new ByTwos();
        for (int i = 0; i < 5; i++)
            Console.WriteLine("Next value is " +
            ob.GetNext() +" previous value is " + ob.GetPrevious() );
        Console.WriteLine("\nResetting");
        ob.Reset();
        for (int i = 0; i < 5; i++)
            Console.WriteLine("Next value is " +
            ob.GetNext() + " previous value is " + ob.GetPrevious());

        Console.WriteLine("\nStarting at 100");
        ob.SetStart(100);
        for (int i = 0; i < 5; i++)
            Console.WriteLine("Next value is " +
            ob.GetNext() + " previous value is " + ob.GetPrevious());
    }
}



// Implement ISeries and add GetPrevious().

class ByTwos : ISeries
{
    int start;
    int val;
    int prev;
    public ByTwos()
    {
        start = 0;
        val = 0;
        prev = -2;
    }

    public int GetNext()
    {
        prev = val;
        val += 2;
        return val;
    }
    public void Reset()
    {
        val = start;
        prev = start - 2;
    }
    public void SetStart(int x)
    {
        start = x;
        val = start;
        prev = val - 2;
    }
    // A method not specified by ISeries.
    public int GetPrevious()
    {
        return prev;
    }
}

public interface ISeries
{
    int GetNext(); // return next number in series
    void Reset(); // restart
    void SetStart(int x); // set starting value
}


