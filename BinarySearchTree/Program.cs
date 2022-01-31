﻿using System;
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
            MyBinaryNode<int> mybinarynode = new MyBinaryNode<int>();
            mybinarynode.CreateNode(56);
            mybinarynode.CreateNode(30);
            mybinarynode.CreateNode(70);
            mybinarynode.CreateNode(22);
            mybinarynode.CreateNode(40);
            mybinarynode.CreateNode(60);
            mybinarynode.CreateNode(95);
            mybinarynode.CreateNode(11);
            mybinarynode.CreateNode(65);
            mybinarynode.CreateNode(3);
            mybinarynode.CreateNode(16);
            mybinarynode.CreateNode(63);
            mybinarynode.CreateNode(67);
            mybinarynode.Root();
            mybinarynode.Display(mybinarynode.root);         
            Console.WriteLine("The number of nodes in BST:{0}", mybinarynode.Size(mybinarynode.root));
        }
    }
}