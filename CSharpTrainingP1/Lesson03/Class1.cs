using System;

namespace Lesson03
{
    public class Class1
    {
        // Методы. От структур к объектам. Исключения

        static void PrintCenter(double msg, int offset)
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - msg.ToString().Length / 2,
                Console.WindowHeight / -offset);
            Console.WriteLine(msg);
        }

        static void PrintCenter(string msg, int offset)
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - msg.Length / 2,
                Console.WindowHeight / 2 - offset);
            Console.WriteLine(msg);
        }

        static double F(double x)
        {
            return x * x;
        }

        static double G(double x, double y)
        {
            return x + y;
        }

        public static void Do()
        {
            Console.ReadLine();

            double res = G(12, 33);//f(2.2)
            PrintCenter(res, 0);

            Console.ReadLine();
        }
    }
}
