// Use object initializers with properties.
using System;
class MyClass
{
    // These are now properties.
    public int Count { get; set; }
    public string Str { get; set; }
}
class ObjInitDemo1
{
    static void Main()
    {
        // Construct a MyClass object by using object initializers.
        MyClass obj = new MyClass { Count = 100, Str = "Testing" };
        Console.WriteLine(obj.Count + " " + obj.Str);
    }
}