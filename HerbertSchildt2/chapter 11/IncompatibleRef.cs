// This program will not compile.
class X
{
    int a;
    public X(int i) { a = i; }
}
class Y
{
    int a;
    public Y(int i) { a = i; }
}
class IncompatibleRef
{
    static void Main()
    {

        X x = new X(10);
        X x2;
        Y y = new Y(5);
        x2 = x; // OK, both of same type
        x2 = y; // Error, not of same type
    }
}