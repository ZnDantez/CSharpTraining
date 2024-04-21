using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice02
{
    public class Factorial
    {
        //        Задача 6. Дано натуральное число n.Вычислить n!
        //Без использования рекурсии:

        static uint Fc1(uint n)
        {
            uint res = 1;
            for (uint i = 0; i <= n; i++)
                if (i == 0)
                    res = 1;
                else
                    res *= i;
            return res;
        }
        public static void Do1()
        {
            Console.WriteLine("Введите число:");
            uint n = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine(Fc1(n));
        }

        //С использованием рекурсии(0!=1, n!=n*(n-1)!):

        static uint Fc2(uint n)
        {
            if (n == 0) return 1;
            else return Fc2(n - 1) * n;
        }
        static void Do2()
        {
            Console.WriteLine("Введите число:");
            uint n = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine(Fc2(n));
        }

    }
}
