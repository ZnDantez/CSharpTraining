using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{
    public class Comparison
    {
        public static void Do()
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
    }
}
