using System;

namespace Lesson02
{
    public class Class1
    {

        #region l1

        public static void Do1()
        {
            Random r = new Random();
            int weather = r.Next(-30, 30);
            Console.WriteLine($"weather = {weather}");

            // <= -5 - нужна шапка
            // От -4 до 9 - решай сам
            // >= 10 не нужна шапка

            if (weather <= -5)
            {
                Console.WriteLine("Нужна шапка");
                Console.WriteLine("Очень холодно");
            }
            if ((weather >= -4) && (weather <= 9))
                Console.WriteLine("Решай сам");
            if (weather >= 10) Console.WriteLine("Шапка не нужна");
        }

        #endregion

        #region l1.5

        public static void Do15()
        {
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine($"{a} = {b}");
            }
            else
            {
                if (a > b)
                {
                    Console.WriteLine($"{a} > {b}");
                }
                else if (a < b)
                {
                    Console.WriteLine($"{a} < {b}");
                }
                else
                {
                    Console.WriteLine("Ты никогда не увидишь этот текст");
                }
            }
        }

        #endregion

    }
}
