
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
            //{
            //    Binary_Tree<int> tree1 = new Binary_Tree<int>(10);
            //    tree1.Insert(5);
            //    tree1.Insert(11);
            //    tree1.Insert(5);
            //    tree1.Insert(-12);
            //    tree1.Insert(15);
            //    tree1.Insert(0);
            //    tree1.Insert(14);
            //    tree1.Insert(-8);
            //    string sortedData = tree1.WalkTree();
            //    Console.WriteLine("Sorted data is: {0}", sortedData);
            //    // in  order traversal

            //    Binary_Tree<string> tree2 = new Binary_Tree<string>("Hello");
            //    tree2.Insert("World");
            //    tree2.Insert("How");
            //    tree2.Insert("Are");
            //    tree2.Insert("You");
            //    tree2.Insert("Today");
            //    tree2.Insert("I");
            //    tree2.Insert("Hope");
            //    tree2.Insert("You");
            //    tree2.Insert("!");
            //    sortedData = tree2.WalkTree();
            //    Console.WriteLine("Sorted data is: {0}", sortedData);
            //}


            BinaryTree<int> btree = new BinaryTree<int>();
            btree.Root = new BinaryTreeNode<int>(1);
            btree.Root.Left = new BinaryTreeNode<int>(2);
            btree.Root.Right = new BinaryTreeNode<int>(3);

            btree.Root.Left.Left = new BinaryTreeNode<int>(4);
            btree.Root.Right.Right = new BinaryTreeNode<int>(5);

            btree.Root.Left.Left.Right = new BinaryTreeNode<int>(6);
            btree.Root.Right.Right.Right = new BinaryTreeNode<int>(7);

            btree.Root.Right.Right.Right.Right = new BinaryTreeNode<int>(8);
        }
    }
}
