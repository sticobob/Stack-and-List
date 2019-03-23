using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace стек_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Системный стек");

            //
            System.Diagnostics.Stopwatch watch;
            long elapsedMs;

            int N = 100000;

            var stack = new System.Collections.Generic.Stack<int>();
            watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i != N; i++)
            {
                stack.Push(i);
            }
            for (int i = 0; i != N; i++)
            {
                stack.Pop();
            }

            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            System.Console.WriteLine(elapsedMs);





            Console.WriteLine(" Фиксированной длинны");
            ////1
            stek<string> str2 = new stek<string>();


            long elapsedMs1;

            watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i != N; i++)
            {
                str2.push2(Convert.ToString(i));
            }
            for (int i = 0; i != N; i++)
            {
                str2.pop2();
            }

            watch.Stop();
            elapsedMs1 = watch.ElapsedMilliseconds;
            System.Console.WriteLine(elapsedMs1);


            Console.WriteLine(" ресайзы, N меньше в 10 раз");
            //2
            Stek2<string> str3 = new Stek2<string>();

            long elapsedMs2;

            watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i != N/10; i++)
            {
                str3.push(Convert.ToString(i));
            }
            for (int i = 0; i != N/10; i++)
            {
                str3.pop();
            }

            watch.Stop();
            elapsedMs2 = watch.ElapsedMilliseconds;
            System.Console.WriteLine(elapsedMs2);

            Console.WriteLine(" создание нового но N меньше в 10 раз, т.к. мой пк не справляется");

            //3
            Stek3<string> str4 = new Stek3<string>();

            long elapsedMs3;

            watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i != N / 10; i++)
            {
                str4.push(Convert.ToString(i));

            }
            for (int i = 0; i != N / 10; i++)
            {
                str4.pop();

            }

            watch.Stop();
            elapsedMs3 = watch.ElapsedMilliseconds;
            System.Console.WriteLine(elapsedMs3);

            Console.WriteLine(" List");



            //4

            List<int> nad = new List<int>();

            long elapsedMs4;

            watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i != N; i++)
            {
                nad.Add(i);
            }
            for (int i = N; i > 0; i--)
            {
                nad.RemoveAt(i - 1);
            }

            watch.Stop();
            elapsedMs4 = watch.ElapsedMilliseconds;
            System.Console.WriteLine(elapsedMs4);
            Console.ReadKey();
        }
    }
}
