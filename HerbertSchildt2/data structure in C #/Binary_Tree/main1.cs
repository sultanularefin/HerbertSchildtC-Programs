
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication1
{
    class main1
    {
        public static void Main(string[] args)
        {
            Binary_Tree<int> tree1 = new Binary_Tree<int>(10);
            tree1.Insert(5);
            tree1.Insert(11);
            tree1.Insert(5);
            tree1.Insert(-12);
            tree1.Insert(15);
            tree1.Insert(0);
            tree1.Insert(14);
            tree1.Insert(-8);
            string sortedData = tree1.WalkTree();
            Console.WriteLine("Sorted data is: {0}", sortedData);
            // in  order traversal

            Binary_Tree<string> tree2 = new Binary_Tree<string>("Hello");
            tree2.Insert("World");
            tree2.Insert("How");
            tree2.Insert("Are");
            tree2.Insert("You");
            tree2.Insert("Today");
            tree2.Insert("I");
            tree2.Insert("Hope");
            tree2.Insert("You");
            tree2.Insert("!");
            sortedData = tree2.WalkTree();
            Console.WriteLine("Sorted data is: {0}", sortedData);
        }
    }
}
