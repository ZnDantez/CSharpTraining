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


        public static void Do1()
        {
            //а) Решение без использования ООП.

            double a = -5;
            double b = 5;
            double h = 0.5;
            Console.WriteLine("{0,10}{1,10}", "x", "F(x)");
            for (double x = a; x <= b; x = x + h)
            {
                Console.WriteLine("{0,10}{1,10:f3}", x, F1(x));
            }


        }

        static double F1(double x)
        {
            return 1 / x;
        }

    }


    //Решение с использованием ООП.


    class Table
    {
        double a = -5;
        double b = 5;
        double h = 0.5;
        public Table()
        {
        }
        public Table(double a, double b, double h)
        {
            this.a = a;
            this.b = b;
            this.h = h;
        }
        double F(double x)
        {
            return 1 / x;
        }
        public void Show(double a, double b, double h)
        {
            Console.WriteLine("{0,10}{1,10}", "x", "F(x)");
            for (double x = a; x <= b; x = x + h)
            {
                Console.WriteLine("{0,10}{1,10:f3}", x, F(x));
            }
        }

        public void Show()
        {
            Console.WriteLine("{0,10}{1,10}", "x", "F(x)");
            for (double x = a; x <= b; x = x + h)
            {
                Console.WriteLine("{0,10}{1,10:f3}", x, F(x));
            }
        }
    }
    public class Program
    {
        static void Main()
        {
            Table table1 = new Table();
            table1.Show();
            Console.WriteLine("Для выполнения следующего расчета нажмите любую клавишу");
            Console.ReadKey();
            Table table2 = new Table(1, 2, 0.5);
            table2.Show();
            Console.ReadKey();
        }
    }
}
