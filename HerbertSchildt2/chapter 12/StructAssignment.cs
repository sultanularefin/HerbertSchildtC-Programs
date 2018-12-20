// Copy a struct.
using System;
// Define a structure.
struct MyStruct
{
    public int x;
}
// Demonstrate structure assignment.
class StructAssignment
{

    static void Main()
    {
        MyStruct a;
        MyStruct b;
        a.x = 10;
        b.x = 20;
        Console.WriteLine("a.x {0}, b.x {1}", a.x, b.x);
        a = b;
        b.x = 30;
        Console.WriteLine("a.x {0}, b.x {1}", a.x, b.x);
    }
}