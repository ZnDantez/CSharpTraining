using System;

namespace Practice01
{
    public class Addition
    {

        //Задача 1. Написать программу сложения двух чисел.


        public static void Do()
        {

            double x;
            double y;

            Console.Write("Введите первое число: ");
            string str = Console.ReadLine();
            x = Convert.ToDouble(str);
            Console.Write("Введите второе число: ");
            y = Convert.ToDouble(Console.ReadLine());

            double z = x + y;
            Console.WriteLine(x + "+" + y + "=" + z); // Преобразование в строку
            Console.ReadLine();

        }
    }
}

