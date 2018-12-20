// Demonstrate verbatim string literals.
using System;
class Verbatim
{
    static void Main()
    {

        Console.WriteLine(@"This is a verbatim
string literal
that spans several lines.
");
        Console.WriteLine(@"Here is some tabbed output:
1 2 3 4
5 6 7 8
");
        Console.WriteLine(@"Programmers say, ""I like C#.""");


        Console.WriteLine(Math.Sqrt(41));

        return;
    }

}