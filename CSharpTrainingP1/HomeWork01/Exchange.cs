using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork01
{
    public class Exchange
    {
        public static void Do()
        {
            //4.Написать программу обмена значениями двух переменных:
            //а) с использованием третьей переменной;
            //б) *без использования третьей переменной.

            int a, b, t;

            a = 3;
            b = 7;

            Console.WriteLine($"a = {a}, b = {b}");

            t = a;
            a = b;
            b = t;

            Console.WriteLine($"a = {a}, b = {b}");

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"a = {a}, b = {b}");
        }
    }
}
