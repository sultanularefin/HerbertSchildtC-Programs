// Use an access modifier with an accessor.
using System;
class PropAccess
{
    int prop; // field being managed by MyProp
    public PropAccess() { prop = 0; }
    /* This is the property that supports access to
    the private instance variable prop. It allows
    any code to obtain the value of prop, but only
    other class members can set the value of prop. */
    public int MyProp
    {
        get
        {
            return prop;
        }
        private set
        { // now, private
            prop = value;
        }
    }

    // This class member increments the value of MyProp.
    public void IncrProp()
    {
        MyProp++; // OK, in same class.
    }
}
// Demonstrate accessor access modifier.
class PropAccessDemo
{
    static void Main()
    {
        PropAccess ob = new PropAccess();
        Console.WriteLine("Original value of ob.MyProp: " + ob.MyProp);
        // ob.MyProp = 100; // can't access set
        ob.IncrProp();
        Console.WriteLine("Value of ob.MyProp after increment: "
        + ob.MyProp);
    }
}