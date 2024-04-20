using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice01
{
    class TriangleArea
    {

        //Задача 6. Написать программу для подсчета площади треугольника

        static bool IsTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && c + b > a;
        }

        static double S(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public static void Do()
        {
            Console.Write("Введите a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите b:");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите c:");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Может существовать треугольник с такими сторонами: " + IsTriangle(a, b, c));
            Console.WriteLine("Площадь треугольника:" + S(a, b, c));
            Console.ReadLine();

        }
    }
}
