using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class FCFS
    {
        public class JobProcessing
        {
            private static List<string> jobs = new List<string>(16);

            //Note that there are 16 elements in the List at this point because
            //    the List was initialized with a capacity of 16 in the code above.
            private static int nextJobPos = 0;

            public static void AddJob(string jobName)
            {
                jobs.Add(jobName);
            }

            public static string GetNextJob()
            {
                if (nextJobPos > jobs.Count - 1)
                    return "NO JOBS IN BUFFER";
                else
                {
                    string jobName = jobs[nextJobPos];
                    nextJobPos++;
                    return jobName;
                }
            }

            public static void Main()
            {
                AddJob("1");
                AddJob("2");
                Console.WriteLine(GetNextJob());
                AddJob("3");
                Console.WriteLine(GetNextJob());
                Console.WriteLine(GetNextJob());
                Console.WriteLine(GetNextJob());
                Console.WriteLine(GetNextJob());
                AddJob("4");
                AddJob("5");
                Console.WriteLine(GetNextJob());
            }
        }
        //The output of this program is as follows:
        //1
        //2
        //3
        //NO JOBS IN BUFFER
        //NO JOBS IN BUFFER
        //4
    }
}

