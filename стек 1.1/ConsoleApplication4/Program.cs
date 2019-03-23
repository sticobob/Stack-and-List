using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack mystack = new Stack();
            mystack.stackfixir();
            Console.WriteLine(mystack._Size);
            Console.WriteLine(mystack._top);

            mystack.push("first");
            mystack.push("second");

            Console.WriteLine(mystack.empty());
            Console.WriteLine(mystack._Size);

            mystack.push("third");
            mystack.push("fourth");

            while (!mystack.empty())
            {
                Console.WriteLine(mystack._top);
                mystack.pop();
            }

            mystack.pop();
            Console.WriteLine(mystack.empty());
            Console.ReadKey();
        }
    }
}
