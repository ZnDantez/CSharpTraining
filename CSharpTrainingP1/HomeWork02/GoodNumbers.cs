using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork02
{
    public class GoodNumbers
    {
        //6. *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000
        //000. «Хорошим» называется число, которое делится на сумму своих цифр.Реализовать
        //подсчёт времени выполнения программы, используя структуру DateTime.

        public static void Do()
        {
            DateTime start = DateTime.Now;
            int sum = 0;

            for (int i = 1; i <= 1_000_000; i++)
            {
                if (IsGood(i))
                {
                    Console.WriteLine(i);
                    sum++;
                }
            }

            Console.WriteLine();
            Console.WriteLine(sum);

            Console.WriteLine(DateTime.Now - start);
        }

        static bool IsGood(int n)
        {
            int sum = 0;
            string s = n.ToString();

            foreach(char c in s)
            {
                sum += Convert.ToInt32(c) - 48;
            }

            if (n % sum == 0) return true;
            else return false;
        }


    }
}
