using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice02
{
    public class DifficultConditions
    {
        //Задача 3. Сложные условия
        //    С клавиатуры вводится возраст от 1 до 50.
        //    Требуется написать программу, которая правильно
        //    определит, какое слово нужно написать после возраста.

        //    Вам 11 лет.
        //    Вам 21 год.
        //    Вам 33 года.

        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Введите возраст, до 50 лет:");
            x = int.Parse(Console.ReadLine());
            string s = "Вам " + x;


            // Год - когда заканчивается на один, кроме 11.
            if (x % 10 == 1 && x != 11) s += " год";
            else
            // Года
            if ((x >= 2 && x <= 4) || (x >= 22 && x <= 24) || (x >= 32 &&
            x <= 34) || (x > 41 && x < 45)) s += " года";
            else
            // Лет
            if ((x == 11) || (x >= 5 && x <= 20) || (x >= 25 && x <=
            30) || (x >= 35 && x < 41) || (x > 44 && x < 51)) s += " лет";
            Console.WriteLine(s);
        }

        //Переделайте программу в метод.
        //В качестве параметра методу передаётся возраст,
        //а метод возвращает строку.
    }
}
