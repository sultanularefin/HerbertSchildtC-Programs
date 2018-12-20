// Demonstrate an enumeration.
using System;
class EnumDemo
{
    enum Apple
    {
        Jonathan, GoldenDel, RedDel, Winesap,
        Cortland, McIntosh
    };
    static void Main()
    {
        string[] color = {
"Red",
"Yellow",
"Red",
"Red",

"Red",
"Reddish Green"
};
        Apple i; // declare an enum variable
        // Use i to cycle through the enum.
        for (i = Apple.Jonathan; i <= Apple.McIntosh; i++)
            Console.WriteLine(i + " has value of " + (int)i);
        Console.WriteLine();
        // Use an enumeration to index an array.
        for (i = Apple.Jonathan; i <= Apple.McIntosh; i++)
            Console.WriteLine("Color of " + i + " is " +
            color[(int)i]);
    }
}