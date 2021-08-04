using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
     public class BaseDoubleStack<T> : IDoubleStack<T>
    {
        protected T[] stack;
        protected int size;
        protected int size2;
        protected int top1;
        protected int top2;

        public BaseDoubleStack(int size)
        {
            this.size = size;
            stack = new T[size];
            this.top1 = -1;
            this.top2 = size;

        }

        public void Add1(T item)
        {
            if (!isFull1())
            {
                //if (isEmpty1()) top1 = 0;
                stack[++top1] = item;
                 
            }    
            else
            {
                throw new Exception("Stack one is full");
            }
        }

        public void Add2(T item)
        {
            if (!isFull2())
            {
                //if (isEmpty2()) top2 = size - 1;
                stack[--top2] = item;
               
            }
            else
            {
                throw new Exception("Stack Two is full");
            }
        }

        public void clear1()
        {
            top1 = 0;
        }

        public void clear2()
        {
            top2 = size - 1;
        }

        public int count1()
        {
            if (isEmpty1())
            {
                return 0;
            }
            else
            {
                return top1 + 1;
            }
        }

        public int count2()
        {
            if (isEmpty2())
            {
                return 0;
            }
            else
            {
                return size - 1 - top2 + 1;
            }
        }

        public bool isEmpty1()
        {
            return top1 == -1;
        }

        public bool isEmpty2()
        {
            return top2 == size;
        }

        public bool isFull1()
        {
            return top1 == size || top1 + 1 == top2; 
        }

        public bool isFull2()
        {
            return top2 == -1 || top2 - 1 == top1;
        }

        public T Peek1()
        {
            if (!isEmpty1())
            {
                return stack[top1];
            }
            else
            {
                throw new Exception("Stack One is Empty");
            }
        }

        public T Peek2()
        {
            if (!isEmpty2())
            {
                return stack[top2];
            }
            else
            {
                throw new Exception("Stack Two is Empty");
            }
        }

        public T Remove1()
        {
            if (!isEmpty1())
            {
                T data = stack[top1];
                --top1;
                return data;
            }
            else
            {
                throw new Exception("Stack One is Empty");
            }
        }

        public T Remove2()
        {
            if (!isEmpty2())
            {
                T data = stack[top2];
                --top1;
                return data;
            }
            else
            {
                throw new Exception("Stack Two is Empty");
            }
        }
        public void show1()
        {
            if (!isEmpty1())
            {
                Console.WriteLine("The first stack is >>> ");
                for (var i = 0; i <= top1; ++i)
                {
                    Console.WriteLine(stack[i]);
                }
                Console.WriteLine("--------------------------------");

            }
            else
            {
                throw new Exception("Stack one is Empty");

            }
        }

        public void show2()
        {
            if (!isEmpty2())
            {
                Console.WriteLine("The Second stack is >>> ");
                for (var i = size - 1; i >= top2; --i)
                {
                    Console.WriteLine(stack[i]);
                }
                Console.WriteLine("--------------------------------");
            }
            else
            {
                throw new Exception("The second stack is Empty ");

            }
        }

    }

    public interface IDoubleStack<T>
    {
        void Add1(T item);
        void Add2(T item);
        T Remove1();
        T Remove2();
        T Peek1();
        T Peek2();
       bool isEmpty1();
        bool isEmpty2();
        bool isFull1();
        bool isFull2();
        int count1();
        int count2();
       void  clear1();
        void clear2();
        void show1();
        void show2();
    }
}
