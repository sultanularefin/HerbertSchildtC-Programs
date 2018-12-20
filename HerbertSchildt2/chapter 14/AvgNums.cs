// This program averages a list of numbers entered by the user.
using System;
using System.IO;

class AvgNums
{
    static void Main()
    {
        string str;
        int n;
        double sum = 0.0;
        double avg, t;
        Console.Write("How many numbers will you enter: ");
        str = Console.ReadLine();
        try
        {
            n = Int32.Parse(str);
        }
        catch (FormatException exc)
        {
            Console.WriteLine(exc.Message);
            return;
        }
        catch (OverflowException exc)
        {
            Console.WriteLine(exc.Message);
            return;
        }
        Console.WriteLine("Enter " + n + " values.");
        for (int i = 0; i < n; i++)
        {
            Console.Write(": ");
            str = Console.ReadLine();
            try
            {
                t = Double.Parse(str);
            }
            catch (FormatException exc)
            {
                Console.WriteLine(exc.Message);
                t = 0.0;
            }
            catch (OverflowException exc)
            {
                Console.WriteLine(exc.Message);
                t = 0;
            }
            sum += t;
        }
        avg = sum / n;
        Console.WriteLine("Average is " + avg);
        Double r;
        bool p;
        str = Console.ReadLine();
       p= Double.TryParse(str,out r);
 
       

       
    }
}