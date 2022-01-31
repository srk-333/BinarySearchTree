using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class MyBinaryTree<T> where T : IComparable<T>
    {
        //Properties
        public T NodeData { get; set; }
        public MyBinaryTree<T> LeftTree { get; set; }
        public MyBinaryTree<T> RightTree { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MyBinaryTree{T}" /> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public MyBinaryTree(T data)
        {
            this.NodeData = data;
            this.LeftTree = null;
            this.RightTree = null;
        }
        int leftCount=0, rightCount=0;
        /// <summary>
        /// Creates the node.
        /// </summary>
        /// <param name="value">The value.</param>
        public void CreateNode(T value)
        {
            T currentNode = this.NodeData;
            if ((currentNode.CompareTo(value)) > 0)
            {
                if (this.LeftTree == null)
                    this.LeftTree = new MyBinaryTree<T>(value);
                else
                    this.LeftTree.CreateNode(value);
            }
            else
            {
                if ((this.RightTree == null))
                    this.RightTree = new MyBinaryTree<T>(value);
                else
                    this.RightTree.CreateNode(value);                
            }
        }
        /// <summary>
        /// Displays Nodes in BST
        /// </summary>
        public void Display()
        {
            if (this.LeftTree != null)
            {
                this.leftCount++;
                this.LeftTree.Display();              
            }
            Console.WriteLine("Node:{0}", this.NodeData.ToString());
            if (this.RightTree != null)
            {
                this.rightCount++;
                this.RightTree.Display();               
            }         
        }
        /// <summary>
        /// Size of BST
        /// </summary>
        public void Size()
        {
            Console.WriteLine("Size"+" "+(1+this.leftCount+this.rightCount));
        }
    }
}