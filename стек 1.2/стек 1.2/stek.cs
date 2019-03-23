using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace стек_1._2
{
    class stek<T>
    {


        public int N = 100000;
        static T[] mas2;
        public static int k = 0;
        public stek()
        {
            mas2 = new T[N];
        }
        public void push2(T b)
        {
            mas2[k] = b;
            k++;
        }
        public void pop2()
        {
            if (k != 0)
            {
                mas2[k - 1] = default(T);
                k--;
            }
        }
        public bool empty()
        {
            if (k == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int size()
        {
            return k;
        }
        public T top()
        {
            if (k != 0)
            {
                return mas2[k - 1];

            }
            else
            { return default(T); }
        }
    }
}
