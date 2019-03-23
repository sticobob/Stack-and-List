using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ЛИст_1
{
    class Listik<T>: IEnumerable, IEnumerator
    {
        int index = -1;
        static T[] arr;
        public int size=0;
        public Listik()
        {
            arr = new T[size];
        }
        public void add(T a)
        {
            size++;
            Array.Resize(ref arr, size);
            arr[size - 1] = a;
        }
        public void insert(int n,T a)
        {
            if (n > size) { return; }
            else
            {
                size++;
                T[] arr2 = new T[size];
                for (int i = 0, i2 = 0; i2 < size; i++, i2++)
                {
                    if (i == n)
                    {
                        arr2[i2] = a;
                        i2++;

                    }
                     arr2[i2] = arr[i]; 
                }
                Array.Resize(ref arr, size);
                arr = arr2;
            }
        }
        public void removeat(int n)
        {
            if (n > size) { return; }
            else
            {
                
                T[] arr2 = new T[size-1];
                for (int i = 0, i2 = 0; i < size; i++, i2++)
                {
                    if (i == n)
                    {
                        i++;
                    }
                    else { arr2[i2] = arr[i]; }
                }
                size--;
                Array.Resize(ref arr, size);
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
            Array.Resize(ref arr, 0);
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
