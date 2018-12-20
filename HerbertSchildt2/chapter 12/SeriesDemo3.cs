// Use a property in an interface.
using System;
public interface ISeries
{
    // An interface property.
    int Next
    {
        get; // return the next number in series
        set; // set next number
    }
}
// Implement ISeries.
class ByTwos : ISeries
{
    int val;
    public ByTwos()
    {
        val = 0;
    }
    // Get or set value.
    public int Next
    {
        get
        {
            val += 2;
            return val;
        }
        set
        {
            val = value;
        }
    }
}
// Demonstrate an interface property.
class SeriesDemo3
{
    static void Main()
    {
        ByTwos ob = new ByTwos();
        // Access series through a property.
        for (int i = 0; i < 5; i++)
            Console.WriteLine("Next value is " + ob.Next);
        Console.WriteLine("\nStarting at 21");
        ob.Next = 21;

        for (int i = 0; i < 5; i++)
            Console.WriteLine("Next value is " + ob.Next);
    }
}