using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class INode<T>
    {
        //Variables
        public T data;
        public INode<T> leftTree;
        public INode<T> rightTree;
        /// <summary>
        /// Initializes a new instance of the <see cref="INode{T}"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public INode(T data)
        {
            this.data = data;
            leftTree = null;
            rightTree = null;
        }
    }
}