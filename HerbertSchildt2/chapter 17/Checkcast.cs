// Use is to avoid an invalid cast.
using System;
class A { }
class B : A { }
class CheckCast
{
    static void Main()
    {
        A a = new A();
        B b = new B();
        // Check to see if a can be cast to B.
        if (a is B) // if so, do the cast
            b = (B)a;
        else // if not, skip the cast
            b = null;
        if (b == null)
            Console.WriteLine("The cast in b = (B) a is NOT allowed.");
        else
            Console.WriteLine("The cast in b = (B) a is allowed");
    }
}