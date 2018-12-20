// Use the NullReferenceException.
using System;
class X
{
    int x;
    public X(int a)
    {
        x = a;
    }
    public int Add(X o)
    {
        return x + o.x;
    }
}
// Demonstrate NullReferenceException.
class NREDemo
{
    static void Main()
    {
        X p = new X(10);
        X q = null; // q is explicitly assigned null
        int val;
        try
        {
            val = p.Add(q); // this will lead to an exception
            
            
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("NullReferenceException!");
            Console.WriteLine("fixing...\n");
            // Now, fix it.
            q = new X(9);
            val = p.Add(q);
        }
        Console.WriteLine("val is {0}", val);
    }
}