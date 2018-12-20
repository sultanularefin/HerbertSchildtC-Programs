using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.chapter_19
{
    class ImmediateExec
    {
        static void Main()
        {
            int[] nums = { 1, -2, 3, 0, -4, 5 };
            // Create a query that obtains the number of positive
            // values in nums.
            int len = (from n in nums
                       where n > 0
                       select n).Count();
            Console.WriteLine("The number of positive values in nums: " + len);
        }
    }
}
