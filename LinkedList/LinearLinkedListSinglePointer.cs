using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinearLinkedListSinglePointer<T> : ILinkedList<T>
    {
        private INode<T> head;
        public LinearLinkedListSinglePointer()
        {
            head = null;
        }
        public void Append(INode<T> node)
        {
            if (head == null)
                head = node;
            else
            {
                INode<T> x = head;
                while (x.Next != null) x = x.Next;
                x.Next = node;
            }
        }

        public void BubbleSort()
        {
            throw new NotImplementedException();
        }

        public void clear()
        {
            INode<T> node = head;
            while (node != null)
            {
                head = head.Next;
                node.Next = null;
                node = head;
            }
        }
        public int count()
        {
            int count = 0;
            INode<T> node = head;
            if (node == null) return count;
            else while (node != null)
                {
                    ++count;
                    node = node.Next;
                }
            return count;
        }

        public bool ContainsCycles()
        {
            throw new NotImplementedException();
        }

        public void Display()
        {
            INode<T> node = head;
            while (node != null)
            {
                node.Display();
                node = node.Next;
            }
        }
         

        public void InsertAfter(INode<T> node, INode<T> newNode)
        {
            throw new NotImplementedException();
        }

        public void InsertBefore(INode<T> node, INode<T> newNode)
        {
            throw new NotImplementedException();
        }

        public void InsertionSort()
        {
            throw new NotImplementedException();
        }

        public void InsertSorted(INode<T> newNode)
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public bool IsSorted(bool DescendingOrder = false)
        {
            throw new NotImplementedException();
        }

        public void MergeSort()
        {
            throw new NotImplementedException();
        }

        public void Prepend(INode<T> node)
        {
            throw new NotImplementedException();
        }

        public INode<T> Remove(INode<T> node)
        {
            throw new NotImplementedException();
        }

        public void RemoveDuplicates()
        {
            throw new NotImplementedException();
        }

        public void Reverse()
        {
            throw new NotImplementedException();
        }

        public INode<T> Search(T element)
        {
            throw new NotImplementedException();
        }

        public void SelectionSort()
        {
            throw new NotImplementedException();
        }

        public INode<T> SplitAlternateNode()
        {
            throw new NotImplementedException();
        }

        public INode<T> SplitInTheMiddle()
        {
            throw new NotImplementedException();
        }
    }
}
