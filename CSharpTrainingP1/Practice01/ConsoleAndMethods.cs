using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice01
{
    class ConsoleAndMethods
    {
        static void Print(string msg, int x, int y)
        {
            // Установим позицию курсора на экране
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }

        static void Print(string msg, ConsoleColor foregroundcolor)
        {
            // Установим цвет символов
            Console.ForegroundColor = foregroundcolor;
            Console.WriteLine(msg);
        }
        // Создайте перегрузку функции, в которой будет указана позиция и цвет

        public static void Do()
        {
            Print("Привет!\n", 10, 10);
            Print("Привет еще раз!", ConsoleColor.Red);
            Console.ReadLine();
        }
    }
}
