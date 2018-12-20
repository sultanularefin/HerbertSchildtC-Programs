using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

/*
 * he .NET Framework Base Class Library includes an implementation of a hash table in the Hashtable class.
 * When adding an item to the Hashtable, 
 * 
 *                      you must provide not only the item, but the unique key by which the item is accessed.
 *                      
 *                       Both the key and item can be of any type. 
 * 
 * In our employee example, the key would be the employee's social security number.
 * Items are added to the Hashtable using                                           the Add() method.
To retrieve an item from the Hashtable, 
 * 
 *              you can index the Hashtable by the key, just like you would index an array by an ordinal value. 
 *  
 * The following short C# program demonstrates this concept. It adds a number of items to a Hashtable, 
 *  associating a string key with each item. Then, the particular item can be accessed using its string key.
 * 
 * 
 * */

namespace ConsoleApplication1
{
    class Hash_Table
    {

        private static Hashtable employees = new Hashtable();

        public static void Main()
        {
            // Add some values to the Hashtable, indexed by a string key
            employees.Add("111-22-3333", "Scott");
            employees.Add("222-33-4444", "Sam");
            employees.Add("333-44-55555", "Jisun");

            // string s =(string)employees["222-33-4444"];


            // Access a particular key
            if (employees.ContainsKey("111-22-3333"))
            {
                string empName = (string)employees["111-22-3333"];
                Console.WriteLine("Employee 111-22-3333's name is: " + empName);
            }
            else
                Console.WriteLine("Employee 111-22-3333 is not in the hash table...");


            /*
             * This code also demonstrates the ContainsKey() method, which returns a Boolean indicating whether or
             * not a specified key was found in the Hashtable. The Hashtable class 
             * 
             *                          contains a Keys property that 
             *                          
             * returns a collection of the keys used in the Hashtable. 
             * This property can be used to enumerate the items in a Hashtable, as shown below:
             */
            Console.Write("\n\n");
            // Step through all items in the Hashtable
            foreach (string key in employees.Keys)
                Console.WriteLine("Value at employees[\"" + key + "\"] = " + employees[key].ToString());


            /*
             * Realize that the order with which the items are inserted and the order of the keys in the Keys collection are not 
             * necessarily the same.   
             * 
             *              The ordering of the Keys collection is based on the slot the key's item was stored. The slot an item is stored 
             *              
             *              depends on the key's hash value and collision resolution strategy. If you run the above code you can see 
             *              that the order the items are enumerated 
             *              
             * doesn't necessarily match with the order with which the items were added to the Hashtable. Running the above code outputs:
             * 
             * 
             */
        }
    }

}
