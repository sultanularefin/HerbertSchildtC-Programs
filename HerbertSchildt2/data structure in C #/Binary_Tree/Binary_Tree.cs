using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Binary_Tree<TItem> where TItem : IComparable<TItem>
    {
        public TItem NodeData { get; set; }
        public Binary_Tree<TItem> LeftTree { get;set; } //set; }  // automatic , public property
        public Binary_Tree<TItem> RightTree { get; set; }//set; }



        public Binary_Tree(TItem nodeValue) //constructor       hree nodeValue is the root node
        {
            this.NodeData = nodeValue;
            this.LeftTree = null;
            this.RightTree = null;
        }

        public void Insert(TItem newItem)
        {
            TItem currentNodeValue = this.NodeData;
            if (currentNodeValue.CompareTo(newItem) > 0) // newItem less than current Node Value then executes
                                                         // currentNodeValue greater than newItem.
            {
                // Insert the new item into the left subtree
                if (this.LeftTree == null)
                {
                    this.LeftTree = new Binary_Tree<TItem>(newItem);
                }
                else
                {
                    this.LeftTree.Insert(newItem);      // recursive call occurs here
                                                    // this calls the insert method(with newItem) and the root node is the left sub 
                                                    // Tree  of the origianl root
                }
            }
            else
            {
                // Insert the new item into the right subtree

                if (this.RightTree == null)
                {
                    this.RightTree = new Binary_Tree<TItem>(newItem);
                }
                else
                {
                    this.RightTree.Insert(newItem);
                }
            }
        }



        public int CompareTo(TItem other)
        {
            throw new NotImplementedException();

//            Less than zero == This instance precedes value.
//Zero ==This instance has the same position in the sort order as value.
//Greater than zero  == This instance follows value  -or-  value is null.

        }



        public void delete(TItem newItem)
        {
            TItem currentNodeValue = this.NodeData;

            if (currentNodeValue.CompareTo(newItem) > 0)

                if (currentNodeValue.CompareTo(newItem) == 0) { 
               
                     if ((this.LeftTree == null) && (this.RightTree == null))
                     {
                     this.NodeData = default(TItem);
                     }

                }
                else
                {


                }

        }


















        public string WalkTree()
        {
            //  // in  order traversal 
            string result = "";
            if (this.LeftTree != null)
            {
                result = this.LeftTree.WalkTree();
            }
            result += String.Format(" {0} ", this.NodeData.ToString());
            if (this.RightTree != null)
            {
                result += this.RightTree.WalkTree();
            }
            return result;
        }
    }
}
