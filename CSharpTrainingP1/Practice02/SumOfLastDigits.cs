using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice02
{
    public class SumOfLastDigits
    {
        //Задача 2. Сумма двух последних цифр
        //    Вывести в диапазоне от 10 до 100 все числа,
        //    сумма двух последних цифр которых равна 10:

        static bool Check(int a)
        {
            if ((a % 10 + a / 10 % 10 == 10)) return true;
            else return false;
        }

        public static void Do()
        {
            for (int i = 10; i <= 100; i++)
                if (Check(i)) Console.WriteLine(i);
        }

    }
}
