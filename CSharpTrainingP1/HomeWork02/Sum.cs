using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork02
{
    public class Sum
    {
        //        3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных
        //положительных чисел.

        public static void Do()
        {
            Console.Write("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            while (a != 0)
            {
                if (IsOdd(a) && IsPositive(a))
                {
                    sum += a;
                }
            }

            Console.WriteLine(a);
        }

        static bool IsOdd(int a)
        {
            if (a % 2 != 0) return true;
            else return false;
        }

        static bool IsPositive(int a)
        {
            if (a > 0) return true;
            else return false;
        }
    }
}
