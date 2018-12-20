// Use a class.
using System;
// Now a class.
class MyClass
{
    public int x;
}
// Now show a class object assignment.
class ClassAssignment
{
    static void Main()
    {
        MyClass a = new MyClass();
        MyClass b = new MyClass();
        a.x = 10;
        b.x = 20;
        Console.WriteLine("a.x {0}, b.x {1}", a.x, b.x);
        a = b;
        b.x = 30;

        Console.WriteLine("a.x {0}, b.x {1}", a.x, b.x);
    }
}