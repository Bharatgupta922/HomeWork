using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node<T> : INode<T>
    {
        public T Data { get; set ; }
        public INode<T> Next { get ; set; }

        public Node()
        {
            Data = default;
            Next = null;
        }
        public int Compare(INode<T> node)
        {

            IComparable comparable = (IComparable)Data;
            return comparable.CompareTo(node.Data);

        }

        public INode<T> Create(T element)
        {
            try
            {
                return new Node<T>
                {
                    Data = element,
                    Next = null
                };
            }
            catch (Exception)
            {
                throw new Exception("there seems to be not enough memory ");
            }
        }


        public void Display()
        {
            Console.Write(Data);
            Console.Write(Next != null ? "->" : "\n");

        }
    }
    public interface INode<T>
    {
        public T Data { get; set; }
        public INode<T> Next { get; set; }
        INode<T> Create(T element);
        void Display();
        int Compare(INode<T> node);

    }
}