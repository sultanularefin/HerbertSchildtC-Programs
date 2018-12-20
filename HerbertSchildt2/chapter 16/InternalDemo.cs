// Use internal.
using System;
class InternalTest
{
    internal int x;
}
class InternalDemo
{
    static void Main()
    {
        InternalTest ob = new InternalTest();
        ob.x = 10; // can access -- in same file
        Console.WriteLine("Here is ob.x: " + ob.x);
    }
}