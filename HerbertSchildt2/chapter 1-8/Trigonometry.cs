// Demonstrate Math.Sin(), Math.Cos(), and Math.Tan().
using System;
class Trigonometry
{
    static void Main()
    {
        Double theta; // angle in radians
        for (theta = 0.1; theta <= 1.0; theta = theta + 0.1)
        {
            Console.WriteLine("Sine of " + theta + " is " +
            Math.Sin(theta));
            Console.WriteLine("Cosine of " + theta + " is " +
            Math.Cos(theta));
            Console.WriteLine("Tangent of " + theta + " is " +
            Math.Tan(theta));
            Console.WriteLine();
        }
        return;

    }
}