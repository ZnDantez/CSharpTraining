using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice03
{
    public class Separation
    {

        public static void Do()
        {
            //            Задача 2.Вычислить частное q и остаток r при делении а на d, не используя
            //операций деления(/) и взятия остатка от деления(%).
            //Дано натуральное(целое неотрицательное) число а и целое положительное число d.Вычислить
            //частное q и остаток r при делении а на d, не используя операций деления(/) и взятия остатка от
            //деления(%).

            int a = 10;
            int d = 3;
            // a/d
            int r = a, q = 0;
            while (r >= d)
            {
                r = r - d;
                q++;
            }
            Console.WriteLine("Частное {0}.\n Остаток {1}", q, r);

        }

    }
}
