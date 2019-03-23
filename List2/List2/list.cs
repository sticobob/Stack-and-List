using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace List2
{
    class Listik<T> : IEnumerable, IEnumerator
    {
        int index = -1;
        static T[] arr;
        public int size = 0;
        public int c1 = 0;
        public int c2 = 0;
        public Listik()
        {
            
            arr = new T[size];
        }
        public Listik(int n)//создание листа фикс длинны
        {
            
            arr = new T[n];
        }
        public void add(T a)
        {
            size++;           
            arr[size - 1] = a;
        }
        public void insert(int n, T a)
        {
            if (n > 50) { return; }
            else
            {
                c2++;
                size++;
                
                for (int i = size-1;i>n;i--)
                {
                    c1++;
                    arr[i] = arr[i - 1];               
                }
                arr[n] = a;
               
            }
        }
        public void removeat(int n)
        {
            if (n > size) { return; }
            else
            {
                
                T[] arr2 = new T[50];
                for (int i = 0, i2 = 0; i < 50; i++, i2++)
                {
                    
                    if (i == n)
                    {
                        
                        i++;
                    }
                    else { arr2[i2] = arr[i];  }
                }
                size--;
                
                arr = arr2;
            }
        }
        public T last()
        {
            return (arr[size - 1]);
        }
        public T first()
        {
            return (arr[0]);
        }
        public void clear()
        {
            size = 0;
            Array.Resize(ref arr, 50);
        }
        public int razm()
        { return (size); }

        //foreach
        public bool MoveNext()
        {
            if (index == arr.Length - 1)
            {
                Reset();
                return false;
            }

            index++;
            return true;
        }

        public void Reset()
        {
            index = -1;
        }

        public object Current
        {
            get
            {
                return arr[index];
            }
        }
        public IEnumerator GetEnumerator()
        {
            return this;
        }
    }
}
