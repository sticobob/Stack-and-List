using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace стек_1._2
{
    class Stek3<T>
    {      
            static T[] mas;
            static T[] mas2;
            public int k = 0;

            public Stek3()
            {
                mas = new T[k];
                mas2 = new T[k];
            }


            public void push(T a)
            {
                k++;
                mas2 = new T[k];
                mas2[k - 1] = a;
                for (int i = 0; i < k - 1; i++)
                {
                    mas2[i] = mas[i];
                }
                mas = mas2;
            }
            public void pop()
            {
                if (k > 0)
                {
                    k--;
                    mas2 = new T[k];
                    for (int i = 0; i < k; i++)
                    {
                        mas2[i] = mas[i];
                    }
                    mas = mas2;
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
                    return mas[k - 1];
                }
                else
                {
                    return default(T);
                }
            }

        }
    }
