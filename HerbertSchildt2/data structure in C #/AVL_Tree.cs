using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class AVL_Tree
    {
        class Program
        {
            static void Main(string[] args)
            {
                AVL tree = new AVL();
                tree.Add(2);
                tree.Add(1);
                tree.Add(0);
                tree.Add(-1);
                tree.Add(-2);
                tree.Add(3);
                tree.Add(5);
                tree.Add(4);

                tree.DisplayTree();
            }
        }
        class AVL
        {
            class Node
            {
                public int data;
                public Node left;
                public Node right;
                public Node(int data)   //constructor
                {
                    this.data = data;
                }
            }
            Node root;
            public AVL()
            {
            }
            public void Add(int data)
            {
                Node newItem = new Node(data);
                if (root == null)
                {
                    root = newItem;
                }
                else  // root is not null.
                {
                    root = RecursiveInsert(root, newItem);
                    //root = null so we dont lose track of the root and we assign a new root if necessary
                }
            }
            private Node RecursiveInsert(Node current, Node n)

            {
                // current is called with root and n  means newItem .
                if (current == null)//base case, we reach this when we go left or right until current is null
                {
                    current = n;
                    return current;
                }
                else if (n.data < current.data)//if the new node is less than the current node
                {
                    current.left = RecursiveInsert(current.left, n);//go left
                    current = balance_tree(current);//calling balance after recursion
                }
                else if (n.data > current.data)//if the new node is greater than the current node
                {
                    current.right = RecursiveInsert(current.right, n);
                    current = balance_tree(current);
                }
                return current;
            }
            private Node balance_tree(Node current)
            {
                int b_factor = balance_factor(current);
                if (b_factor > 1)
                {
                    if (balance_factor(current.left) > 0)
                    {
                        current = RotateLL(current);
                    }
                    else
                    {
                        current = RotateLR(current);
                    }
                }
                else if (b_factor < -1)
                {
                    if (balance_factor(current.right) > 0)
                    {
                        current = RotateRL(current);
                    }
                    else
                    {
                        current = RotateRR(current);
                    }
                }
                return current;
            }
            public void Delete(int target)
            {
                Delete(root, target);
            }
            public void Find(int key)
            {
                if (Find(key, root).data == key)
                {
                    Console.WriteLine("{0} was found!", key);
                }
                else
                {
                    Console.WriteLine("Nothing found!");
                }
            }
            private Node Find(int target, Node current)
            {

                if (target < current.data)
                {
                    if (target == current.data)
                    {
                        return current;
                    }
                    else
                        return Find(target, current.left);
                }
                else
                {
                    if (target == current.data)
                    {
                        return current;
                    }
                    else
                        return Find(target, current.right);
                }

            }
            public void DisplayTree()
            {
                InOrderDisplayTree(root);
                Console.ReadLine();
            }
            private void InOrderDisplayTree(Node current)
            {
                if (current != null)
                {
                    InOrderDisplayTree(current.left);
                    Console.Write("({0}) ", current.data);
                    InOrderDisplayTree(current.right);
                }
            }
            private int max(int l, int r)//returns maximum of two integers
            {
                return l > r ? l : r;
            }
            private int getHeight(Node current)
            {
                int height = 0;
                if (current != null)
                {
                    int l = getHeight(current.left);
                    int r = getHeight(current.right);
                    int m = max(l, r);
                    height = m + 1;
                }
                return height;
            }
            private int balance_factor(Node current)
            {
                int l = getHeight(current.left);
                int r = getHeight(current.right);
                int b_factor = l - r;
                return b_factor;
            }
            private Node RotateRR(Node parent)
            {
                Node pivot = parent.right;
                parent.right = pivot.left;
                pivot.left = parent;
                return pivot;
            }
            private Node RotateLL(Node parent)
            {
                Node pivot = parent.left;
                parent.left = pivot.right;
                pivot.right = parent;
                return pivot;
            }
            private Node RotateLR(Node parent)
            {
                Node pivot = parent.left;
                parent.left = RotateRR(pivot);
                return RotateLL(parent);
            }
            private Node RotateRL(Node parent)
            {
                Node pivot = parent.right;
                parent.right = RotateLL(pivot);
                return RotateRR(parent);
            }
            private Node Delete(Node current, int target)
            {
                Node parent;
                if (current == null)
                { return null; }
                else
                {
                    //left subtree
                    if (target < current.data)
                    {
                        current.left = Delete(current.left, target);
                        if (balance_factor(current) == -2)
                        {
                            if (balance_factor(current.left) <= 0)
                            {
                                current = RotateRR(current);
                            }
                            else
                            {
                                current = RotateRL(current);
                            }
                        }
                    }
                    //right subtree
                    else if (target > current.data)
                    {
                        current.right = Delete(current.right, target);
                        if (balance_factor(current) == 2)
                        {
                            if (balance_factor(current.right) <= 0)
                            {
                                current = RotateLL(current);
                            }
                            else
                            {
                                current = RotateLR(current);
                            }
                        }
                    }
                    //if target is found
                    else
                    {
                        if (current.right != null)
                        {
                            //delete its inorder successor
                            parent = current.right;
                            while (parent.left != null)
                            {
                                parent = parent.left;
                            }
                            current.data = parent.data;
                            current.right = Delete(current.right, parent.data);
                            if (balance_factor(current) == 2)//rebalancing
                            {
                                if (balance_factor(current.left) <= 0)
                                {
                                    current = RotateLL(current);
                                }
                                else { current = RotateLR(current); }
                            }
                        }
                        else
                        {
                            return current.left;
                        }
                    }
                }
                return current;
            }
        }


    }
}
