using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01
{
    class InputAndOutput
    {
        public static void Do()
        {
            // Программа сложения двух чисел

            Console.Write("Введите первое число: ");
            int valueA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int valueB = int.Parse(Console.ReadLine());

            var result = valueA + valueB;

            Console.WriteLine(result);
            Console.WriteLine($"{valueA} + {valueB} = {result}");

            Console.ReadLine();
        }
    }
}
