using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork01
{
    public class Distance
    {
        //3. а) Написать программу,
        //которая подсчитывает расстояние между точками с координатами x1, y1 и x2, y2
        //по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
        //Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);

        //б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.


        static double r;
        static int x1, y1;
        static int x2, y2;

        public static void Do()
        {
            x1 = 3; y1 = 5;
            x2 = 6; y2 = 10;

            FindDistance();

            Console.WriteLine($"r = {r:F3}");
            Console.WriteLine($"r = {r:0.00}");
            Console.WriteLine($"r = {Math.Round(r, 5)}");
        }

        static void FindDistance()
        {
            r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
