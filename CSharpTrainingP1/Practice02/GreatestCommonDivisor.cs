using System;

namespace Practice02
{
    public class GreatestCommonDivisor
    {
        //Задача 1. Алгоритм нахождения НОД и организация метода
        //    Реализовать метод нахождения NOD, используя алгоритм Евклида:

        static int NOD(int a, int b)
        {
            while (a != b)
                if (a > b) a = a - b;
                else b = b - a;
            
            return a;
        }

        public static void Do()
        {
            int a = 532;
            int b = 224;
            Console.WriteLine(NOD(a, b));
        }

    }
}
