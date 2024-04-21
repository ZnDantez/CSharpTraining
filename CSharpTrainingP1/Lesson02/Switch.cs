using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{
    public class Switch
    {
        public static void Do()
        {
            Random r = new Random();
            double day = r.Next(1, 15); // [1, 15)
            Console.WriteLine($"day = {day}");

            switch (day)
            {
                case 1: Console.WriteLine("Пн"); break;
                case 2: Console.WriteLine("Вт"); break;
                case 3: Console.WriteLine("Ср"); break;
                case 4: Console.WriteLine("Чт"); break;
                case 5: Console.WriteLine("Пт"); break;
                case 6: Console.WriteLine("Сб"); break;
                case 7: Console.WriteLine("Вс"); break;

                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                    Console.WriteLine("Такого дня не существует");
                    break;

                default: Console.WriteLine("Да ты заебал"); break;

            }
        }
    }
}
