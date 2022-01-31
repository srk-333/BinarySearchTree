using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Program");
            ViewBST();
            Console.ReadLine();
        }
        /// <summary>
        /// Method to Initialize Nodes.
        /// </summary>
        public static void ViewBST()
        {
            MyBinaryTree<int> tree = new MyBinaryTree<int>(56);
            tree.CreateNode(30);
            tree.CreateNode(70);
            tree.CreateNode(22);
            tree.CreateNode(40);
            tree.CreateNode(60);
            tree.CreateNode(95);
            tree.CreateNode(11);
            tree.CreateNode(65);
            tree.CreateNode(3);
            tree.CreateNode(16);
            tree.CreateNode(63);
            tree.CreateNode(67);
            Console.WriteLine("Display Nodes present in Binary Search Tree");
            tree.Display();
            tree.Size();
        }
    }
}