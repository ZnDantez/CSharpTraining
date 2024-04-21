using System;

namespace HomeWork02
{
    public class Minimum
    {
        //1. Написать метод, возвращающий минимальное из трёх чисел.

        public static void Do()
        {
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите третье число: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int result;

            if (a < b && a < c) result = a;
            else if (b < c) result = b;
            else result = c;
        }
    }
}
