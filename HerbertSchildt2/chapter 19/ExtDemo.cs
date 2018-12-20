using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApplication1.chapter_19
{ 
static class MyExtMeths
{
    // Return the reciprocal of a double.
    public static double Reciprocal(this double v)
    {
        return 1.0 / v;
    }
    // Reverse the case of letters within a string and
    // return the result.
    public static string RevCase(this string str)
    {
        string temp = "";
        foreach (char ch in str)
        {
            if (Char.IsLower(ch)) temp += Char.ToUpper(ch, CultureInfo.CurrentCulture);
            else temp += Char.ToLower(ch, CultureInfo.CurrentCulture);
        }
        return temp;
    }
    // Return the absolute value of n / d.
    public static double AbsDivideBy(this double n, double d)
    {
        return Math.Abs(n / d);
    }
}
class ExtDemo
{
    static void Main()
    {
        double val = 8.0;
        string str = "Alpha Beta Gamma";
        // Call the Reciprocal() extension method.
        Console.WriteLine("Reciprocal of {0} is {1}",
        val, val.Reciprocal());
        // Call the RevCase() extension method.
        Console.WriteLine(str + " after reversing case is " +
        str.RevCase());
        // Use AbsDivideBy();
        Console.WriteLine("Result of val.AbsDivideBy(-2): " +
        val.AbsDivideBy(-2));
    }
}
}