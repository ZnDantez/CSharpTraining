using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork02
{
    public class NumberOfDigits
    {
        public static void Do()
        {
            //2.Написать метод подсчета количества цифр числа.

            Console.Write("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(NumOfD(a));
        }

        static int NumOfD(int a)
        {
            string s = Convert.ToString(a);
            return s.Length;
        }
    }
}
