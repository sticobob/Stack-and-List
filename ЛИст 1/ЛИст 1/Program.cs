using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛИст_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> ak = new List<int>();
            //ak.Add(2);
            //ak.Insert(1, 4);
            //foreach (int i in ak)
            //{ Console.WriteLine(i); }
            //Console.ReadKey();
            Listik<int> lis = new Listik<int>();
            lis.add(12);
            lis.add(31);
            foreach (var i in lis)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("ggg");
            lis.insert(1, 222);
            foreach(var i in lis)
            {
                Console.WriteLine(i);
            }
            lis.removeat(2);
            foreach (var i in lis)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("f");
            Console.WriteLine(lis.last());
            Console.WriteLine(lis.first());
            Console.WriteLine("razmer"+lis.razm());
            lis.clear();
            Console.WriteLine("razmer"+lis.razm());
            foreach (var i in lis)
                Console.WriteLine("dd" + i);
            Console.ReadKey();
        }
    }
}
