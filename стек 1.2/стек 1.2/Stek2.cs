using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace стек_1._2
{
    class Stek2<T>
    {

        static T[] mas;
        public static int k = 0;
        public Stek2()
        {
            mas = new T[k];
        }

        public void push(T a)
        {
            k++;
            Array.Resize(ref mas, k);
            mas[k - 1] = a;
        }

        public void pop()
        {
            if (k != 0)
            {
                k--;
                Array.Resize(ref mas, k);
            }
        }

        public bool empty()
        {

            return k == 0;
        }

        public int size()
        {
            return k;
        }

        public T top()
        {
            if (k != 0)
            {
                return mas[k - 1];
            }
            else
            {
                return default(T);
            }
        }

    }
}
