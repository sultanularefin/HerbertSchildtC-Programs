// Use a let clause and a nested from clause.
using System;
using System.Linq;
class LetDemo
{
    static void Main()
    {
        string[] strs = { "alpha", "beta", "gamma" };
        // Create a query that obtains the characters in the
        // strings, returned in sorted order. Notice the use
        // of a nested from clause.
        var chrs = from str in strs
                   let chrArray = str.ToCharArray()
                   from ch in chrArray
                   orderby ch
                   select ch;
        Console.WriteLine("The individual characters in sorted order:");
        // Execute the query and display the results.
        foreach (char c in chrs) Console.Write(c + " ");
        Console.WriteLine();

       
    }
}