using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice02
{
    class FibbonacciSequence
    {
        //        Последовательность Фибоначчи определяется так: a0=0, a1=1, ak=ak-1+ak-2 при k>=2.
        //        Дано n, вычислить an.

        //Вариант 1. Использования цикла for:

        static uint Fib1(uint n)
        {
            uint a0 = 0;
            uint a1 = 1;
            uint a = a1;
            for (int i = 2; i <= n; i++)
            {
                a = a0 + a1;
                a0 = a1;
                a1 = a;
            }
            return a1;
        }
        public static void Do1()
        {
            Console.WriteLine("Введите число:");
            uint n = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine(Fib1(n));
        }

        //Вариант 2. Использование рекурсии:

        static uint Fib2(uint n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fib2(n - 1) + Fib2(n - 2);
        }
        public static void Do2()
        {
            Console.WriteLine("Введите число:");
            uint n = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine(Fib2(n));
        }

    }
}
