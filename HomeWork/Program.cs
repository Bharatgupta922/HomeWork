using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            IDoubleStack<int> st = new BaseDoubleStack<int>(5);
            Console.WriteLine(st.count1());
            st.Add1(5);
            st.Add1(45);
            st.Add2(9);
            st.Add2(6);
            st.show1();
            st.show2();

        }
    }
}
