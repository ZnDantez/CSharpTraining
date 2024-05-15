using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice03
{
    public class Tabulation
    {

        //        Задача 3. Написать программу табуляции произвольной функции в диапазоне
        //от a до b.
        //Написать программу табуляции произвольной функции в диапазоне от a до b.Функция задаётся
        //программно.

        #region a

        public static void Do1()
        {
            //а) Решение без использования ООП.

            double a = -5;
            double b = 5;
            double h = 0.5;
            Console.WriteLine("{0,10}{1,10}", "x", "F(x)");
            for (double x = a; x <= b; x = x + h)
            {
                Console.WriteLine("{0,10}{1,10:f3}", x, F(x));
            }


        }

        static double F(double x)
        {
            return 1 / x;
        }

        #endregion

        public static void Do2()
        {
            //б) Решение с использованием ООП.

        }


    }
}
