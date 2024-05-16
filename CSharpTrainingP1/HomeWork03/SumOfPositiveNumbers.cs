using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork03
{
    public class SumOfPositiveNumbers
    {
        //2. а) С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
        //Требуется подсчитать сумму всех нечётных положительных чисел.
        //Сами числа и сумму вывести на экран, используя tryParse.

        public static void Do()
        {
            int sum = 0;
            int next = 1;
            EnterTheNumber(out next);

            while(next != 0)
            {
                if (IsGood(next))
                    sum += next;
                EnterTheNumber(out next);
            }

            Console.WriteLine($"Сумма всех нечетных положительных чисел {sum}");
        }

        public static int EnterTheNumber(out int a)
        {
            Console.Write("Введите число: ");
            if (int.TryParse(Console.ReadLine(), out a))
                return a;
            else EnterTheNumber(out a); return a;
        }

        static bool IsGood(int a)
        {
            if (a % 2 == 0 && a > 0) return true;
            else return false;
        }

        // Трайпарс, ауты и рекурсия. Идеально блять
    }
}
