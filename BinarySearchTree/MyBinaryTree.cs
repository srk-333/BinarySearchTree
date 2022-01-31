using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class MyBinaryNode<T> where T : IComparable
    {
        //Variable.
        public INode<T> root;
        /// <summary>
        /// insert the node into bst.
        /// </summary>
        /// <param name="value"></param>
        public void CreateNode(T value)
        {
            INode<T> newNode = new INode<T>(value);
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                INode<T> parentNode = root;
                INode<T> currentNode = root;
                while (true)
                {
                    parentNode = currentNode;
                    if (currentNode.data.CompareTo(value) >= 0)
                    {
                        currentNode = currentNode.left;
                        if (currentNode == null)
                        {
                            parentNode.left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        currentNode = currentNode.right;
                        if (currentNode == null)
                        {
                            parentNode.right = newNode;
                            break;
                        }
                    }
                }
            }
        }
        //Display Root Node.
        public void Root()
        {
            do
            {
                Console.WriteLine("BST Root Node:" + root.data);
                break;
            } while (root != null);
        }
        /// <summary>
        /// Displays Nodes in BST
        /// </summary>
        public void Display(INode<T> parent)
        {
            if (parent != null)
            {
                Display(parent.left);
                Display(parent.right);
                Console.WriteLine("{0} is BST Node", parent.data);
            }
        }
        /// <summary>
        /// length of bst
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int Size(INode<T> root)
        {
            if (root == null)
                return 0;
            else
                return (Size(root.left) + 1 + Size(root.right));
        }
        /// <summary>
        /// Searches the specified key in BST.
        /// </summary>
        /// <param name="root">The root.</param>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        public bool Search(INode<T> root, T key)
        {

            if (root == null)
            {
                return false;
            }
            if (root.data.CompareTo(key) == 0)
            {
                return true;
            }
            else if (root.data.CompareTo(key) > 0)
            {
                return Search(root.left, key);
            }
            else
            {
                return Search(root.right, key);
            }
        }
    }
}