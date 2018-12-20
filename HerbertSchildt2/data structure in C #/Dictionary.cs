using System;
using System.Collections.Generic;
using System.Collections;


namespace ConsoleApplication1
{
    class Dictionary
    {
        
        public static void Main()
        {

            Dictionary<int, string> dict =
            new Dictionary<int, string>();
            // Create a Dictionary that holds employee
            // names and their corresponding salary.
            

            dict.Add(110189, "Scott Mitchell");
            dict.Add(110191, "Jisun Lee");

            if (dict.ContainsKey(110189))
            {
                // string empname=(string) dict["110189"];

                // Get a collection of the keys (names).

                string em = (string)dict[110189];
                Console.WriteLine(em);
                ICollection<int> c = dict.Keys;

                foreach (int sa in c)
                    Console.WriteLine("{0}  number employee's name is   : {1}", sa, dict[sa]);
            }
            else Console.WriteLine("\n\n not found");
        }
    }

}