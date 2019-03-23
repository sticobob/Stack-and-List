using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack1._3
{
    class MyStack<T>
    {
        int count;
        List<T> stack;

        public MyStack()
        {
            count = 0;
            stack = new List<T>();
        }

        public void push(T a)
        {
            count += 1;
            stack.Add(a);
        }

        public T pop()
        {
            try
            {
                T tmp = stack[count - 1];
                stack.RemoveAt(count - 1);
                count -= 1;
                return tmp;
            }
            catch
            {
                return default(T);
            }

        }

        public bool empty()
        {
            if (count == 0)
                return true;
            else return false;
        }

        public int size()
        {
            return count;
        }

        public T top()
        {
            try
            { return stack[count - 1]; }
            catch
            { return default(T); }
        }
    }
}
