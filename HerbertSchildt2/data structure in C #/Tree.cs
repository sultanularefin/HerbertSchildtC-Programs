using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{


    class Tree
    {


        public class TreeNode<T> : IEnumerable<TreeNode<T>>
        {

            public T Data { get; set; }
            public TreeNode<T> Parent { get; set; }
            public ICollection<TreeNode<T>> Children { get; set; }

            public TreeNode(T data)
            {
                this.Data = data;
                this.Children = new LinkedList<TreeNode<T>>();
            }

            public TreeNode<T> AddChild(T child)
            {
                TreeNode<T> childNode = new TreeNode<T>(child) { Parent = this };
                this.Children.Add(childNode);
                return childNode;
            }

            // other features ...
        }


    }
}

TreeNode<string> root = new TreeNode<string>("root");
{
    TreeNode<string> node0 = root.AddChild("node0");
    TreeNode<string> node1 = root.AddChild("node1");
    TreeNode<string> node2 = root.AddChild("node2");
    {
        TreeNode<string> node20 = node2.AddChild(null);
        TreeNode<string> node21 = node2.AddChild("node21");
        {
            TreeNode<string> node210 = node21.AddChild("node210");
            TreeNode<string> node211 = node21.AddChild("node211");
        }
    }
    TreeNode<string> node3 = root.AddChild("node3");
    {
        TreeNode<string> node30 = node3.AddChild("node30");
    }
}
