using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Стек_1._3
{
    class Program
    {
        static void f(int x)
        {
            if (x > 0)
            {
                System.Console.WriteLine(x);
                f(x - 1);
                System.Console.WriteLine(x);
            }
        }
        static void Main(string[] args)
        {
            int x = 5;
            var st = new System.Collections.Generic.Stack<int>();
            bool dir = true;
            st.Push(x);
            while (st.Count>0)
            {
                x = st.Peek();
                st.Pop();
                if ((x > 0) && (dir))
                {
                   
                    st.Push(x);
                    st.Push(x - 1);
                }
                else
                    dir = false;
                if (x != 0)  Console.WriteLine(x);
            }
            Console.ReadKey();
            Console.WriteLine();
            f(3);
            Console.ReadKey();
        }
    }
}
