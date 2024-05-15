using System;

namespace Practice03
{
    public class Max
    {
//        Задача 1. Найти максимальное число.
//На вход программе подаётся последовательность чисел, заканчивающаяся нулём.
//Найти максимальное число.

        public static void Do()
        {
            int a = int.Parse(Console.ReadLine());
            int max = a;
            while (a != 0)
            {
                a = int.Parse(Console.ReadLine());
                if (a > max) max = a;
            }
            Console.WriteLine(max);

        }
    }
}
