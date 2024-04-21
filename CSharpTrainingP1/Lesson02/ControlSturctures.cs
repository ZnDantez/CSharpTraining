using System;

namespace Lesson02
{
    public class ControlSturctures
    {
        // Управляющие конструкции

        #region l1 if

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

        #region l2 else-if

        public static void Do2()
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

        #region l3 switch

        public static void Do3()
        {
            Random r = new Random();
            double day = r.Next(1, 15); // [1, 15)
            Console.WriteLine($"day = {day}");

            switch (day)
            {
                case 1: Console.WriteLine("Пн"); break;
                case 2: Console.WriteLine("Вт"); break;
                case 3: Console.WriteLine("Ср"); break;
                case 4: Console.WriteLine("Чт"); break;
                case 5: Console.WriteLine("Пт"); break;
                case 6: Console.WriteLine("Сб"); break;
                case 7: Console.WriteLine("Вс"); break;

                case 8:
                case 9:
                case 10:
                case 11:
                case 12: Console.WriteLine("Такого дня не существует");
                    break;

                default: Console.WriteLine("Да ты заебал"); break;

            }
        }

        #endregion

        #region l4 for

        public static void Do4()
        {
            for (int counter = 1; counter <= 100; counter++)
            {
                Console.WriteLine($"{counter,3} Привет, мир!");
            }

            Console.WriteLine();

            for (int i = 1; i <= 100; i++)
                Console.WriteLine($"{i,-3} Привет, мир!");
        }

        #endregion

        #region l5 while

        public static void Do5()
        {
            int i = 1;

            while(i <= 10)
            {
                Console.WriteLine($"{i,2} Привет, мир!");
                i++;
            }
        }

        #endregion

        #region l6 do-while

        public static void Do6()
        {
            int i = 100;

            if (i <= 10)
            {
                do
                {
                    Console.WriteLine($"{i,-3} Привет, мир!");
                    i++;
                } while (i <= 10);

            }

        }

        #endregion

        #region l7 comparison

        public static void Do7()
        {
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int max;

            if (a > b)
                max = a;
            else
                max = b;

            //=============================>

            max = a > b ? a : b;

            //-------------------------------------

            Console.Write("Введите третье число: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                max = a;
            }
            else
            {
                if (b > c)
                {
                    max = b;
                }
                else
                {
                    max = c;
                }
            }

            //====================================>

            if (a > b && a > c) max = a;
            else if (b > c) max = b;
            else max = c;

            //====================================>

            max = (a > b && a > c) ? a : (b > c) ? b : c;

            Console.WriteLine($"max = {max}");
        }

        #endregion

        #region l8 break

        public static void Do8()
        {
            Console.WriteLine("До какого числа показывать таблицу умножения: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= 10; i++)
            {
                if (i == n) break;
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i,2} x {j,3} = {i * j}");
                }
                Console.WriteLine();
            }
        }

        #endregion

        #region l9 continue

        public static void Do9()
        {
            Console.Write("Какое значение нужно пропустить: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= 10; i++)
            {
                if (i == n) continue;
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i,2} x {j,2} = {i * j}");
                }
                Console.WriteLine();
            }
        }

        #endregion

    }
}
