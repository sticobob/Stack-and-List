using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack1._3
{
    class Program
    {
        public static int evaluate(string str)
        {
            MyStack<int> values = new MyStack<int>();
            MyStack<char> ops = new MyStack<char>();
            str += ".";
            int k = 0;
            String number = "";
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == ' ') continue; // пропускаем пробелы
                if (str[i] >= '0' && str[i] <= '9')
                {
                    number += str[i];

                    k++;
                    if (str[i + 1] == '+' || str[i + 1] == '-' || str[i + 1] == '*' || str[i + 1] == '/' || str[i + 1] == '^' || str[i + 1] == '.' || str[i + 1] == '(' || str[i + 1] == ')')
                    {
                        values.push(System.Convert.ToInt32(number));
                        //Console.WriteLine(values.top());
                        number = "";


                    }
                }
                else if (str[i] == '(')
                    ops.push(str[i]);  // Текущий символ - открывающаяся скобка, добавляем в ops
                else if (str[i] == ')')
                { // Скобка закрытия - все что внутри надо посчитать
                    while (ops.top() != '(')
                    {
                        Console.WriteLine(Convert.ToString(k = values.pop()) + Convert.ToString(values.pop()) + Convert.ToString(ops.top()));
                        values.push(k);
                        values.push(execOP(ops.pop(), values.pop(), values.pop()));
                    }
                    ops.pop();
                }
                else if (str[i] == '+' || str[i] == '-' || str[i] == '*' || str[i] == '/' || str[i] == '^')
                { // текущий символ - операция
                  // Пока верх стека ops имеет тот же или больший приоритет к текущей операции
                    while (ops.size() != 0 && priority(str[i], ops.top()))
                    {
                        Console.WriteLine(Convert.ToString(k = values.pop()) + Convert.ToString(values.top()) + Convert.ToString(ops.top()));
                        values.push(k);
                        values.push(execOP(ops.pop(), values.pop(), values.pop()));
                    } // одна операция с двумя операндами
                    ops.push(str[i]); /*Console.WriteLine(ops.top());*/ // добавляем в стек с операциями
                }

            }
            while (ops.size() != 0)
            {
                Console.WriteLine(Convert.ToString(k = values.pop()) + Convert.ToString(values.top()) + Convert.ToString(ops.top()));
                values.push(k);
                values.push(execOP(ops.pop(), values.pop(), values.pop()));

            }

            return values.pop();

        }
        // функция для выполнения одной из операций с двумя операндами
        public static int execOP(char op, int b, int a)
        {
            switch (op)
            {
                case '-':
                    return a - b;
                case '+':
                    return a + b;
                case '/':
                    return a / b;
                case '*':
                    return a * b;
                case '^':
                    return Convert.ToInt32(Math.Pow(a, b));
                default:
                    return default(int);
            }
        }
        // Если op2 имеет больший или такой же приоритет, как и op1, возвращаем true, иначе false.
        public static bool priority(char op1, char op2)
        {
            if (op2 == '(' || op2 == ')')
                return false;
            if (op1 == '^')
                return false;
            if ((op1 == '*' || op1 == '/') && (op2 == '+' || op2 == '-'))
                return false;
            else
                return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите выражение");
            //evaluate(Console.ReadLine());
            Console.WriteLine(evaluate(Console.ReadLine()));
        }
    }
}