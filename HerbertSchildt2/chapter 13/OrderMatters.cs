// Derived exceptions must appear before base class exceptions.
using System;
// Create an exception.
class ExceptA : Exception
{
    public ExceptA(string message) : base(message) { }

    public override string ToString()
    {
        return Message;
    }
}
// Create an exception derived from ExceptA.
class ExceptB : ExceptA
{
    public ExceptB(string message) : base(message) { }
    public override string ToString()
    {
        return Message;
    }
}
class OrderMatters
{
    static void Main()
    {
        for (int x = 0; x < 3; x++)
        {
            try
            {
                if (x == 0) throw new ExceptA("Caught an ExceptA exception");
                else if (x == 1) throw new ExceptB("Caught an ExceptB exception");
                else throw new Exception();
            }
            catch (ExceptB exc)
            {
                Console.WriteLine(exc);
            }
            catch (ExceptA exc)
            {
                Console.WriteLine(exc);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
        }
    }
}