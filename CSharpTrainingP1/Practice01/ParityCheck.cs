using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice01
{
    class ParityCheck
    {
        //Задача 4. Разработать метод проверки чётности числа.Метод возвращает true, 
        //    если число чётное, и false, если число нечётное.



        static bool Odd(int n)
        {
            return n % 2 == 0;
        }

        public static void Do(string[] args)
        {
            int value = 100500;
            Console.WriteLine(Odd(value));
        }

    }
}
