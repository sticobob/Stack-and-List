using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class Stack
    {
        private string[] item;//все эл
        private int count;//размер, нужен ли?
        const int n = 10;//стандарт размер
        public int size;//размер от чела
        private int top;//номер верхнего эл.

        public void stackfixir()//по умолч
        {
            item = new string[n];
            top = 0;

        }
      
        public string _top
        {
            get
            {
                if (this.empty())
                    return ("");
                return item[top - 1];
            }
        }

        public int _Size
        {
            get
            {

                return top;
            }
        }
        public bool Full()
        {
            return top == n - 1;
        }
        public bool empty()
        {
            return top == 0;
        }
        public void push(string El)
        {
            if (this.Full())
                return;

            item[top] = El;
            top++;

        }
        public string pop()
        {

            if (this.empty())
                return ("кончился");

            string item2 = item[top - 1];
            top--;            
            return item2;
        }
    }
}
