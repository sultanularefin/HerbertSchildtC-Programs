using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.chapter_19
{
    class ExtMethods
    {
        static void Main()
        {
            int[] nums = { 3, 1, 2, 5, 4 };
            Console.WriteLine("The minimum value is " + nums.Min());
            Console.WriteLine("The maximum value is " + nums.Max());
            Console.WriteLine("The first value is " + nums.First());
            Console.WriteLine("The last value is " + nums.Last());
            Console.WriteLine("The sum is " + nums.Sum());
            Console.WriteLine("The average is " + nums.Average());
            if (nums.All(n => n > 0))
                Console.WriteLine("All values are greater than zero.");
            if (nums.Any(n => (n % 2) == 0))
                Console.WriteLine("At least one value is even.");
            if (nums.Contains(3))
                Console.WriteLine("The array contains 3.");
        }
    }
}
