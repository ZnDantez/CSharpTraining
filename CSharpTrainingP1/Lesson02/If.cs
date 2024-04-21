using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{
    public class If
    {
        public static void Do()
        {
            Random r = new Random();
            int weather = r.Next(-30, 30);
            Console.WriteLine($"weather = {weather}");

            // <= -5 - нужна шапка
            // От -4 до 9 - решай сам
            // >= 10 не нужна шапка

            if (weather <= -5)
            {
                Console.WriteLine("Нужна шапка");
                Console.WriteLine("Очень холодно");
            }
            if ((weather >= -4) && (weather <= 9))
                Console.WriteLine("Решай сам");
            if (weather >= 10) Console.WriteLine("Шапка не нужна");
        }
    }
}
