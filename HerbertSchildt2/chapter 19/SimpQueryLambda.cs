// Use the query methods to create a simple query.
// This is a reworked version of the first program in this chapter.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.chapter_19
{
    class SimpQueryLambda
    {
        static void Main()
        {
            int[] nums = { 1, -2, 3, 0, -4, 5 };
            // Use Where() and Select() to create a simple query.
            var posNums = nums.Where(n => n > 0).Select(r => r);
            Console.Write("The positive values in nums: ");
            // Execute the query and display the results.
            foreach (int i in posNums) Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}
