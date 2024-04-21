using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{
    public class ElseIf
    {

        public static void Do()
        {
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine($"{a} = {b}");
            }
            else
            {
                if (a > b)
                {
                    Console.WriteLine($"{a} > {b}");
                }
                else if (a < b)
                {
                    Console.WriteLine($"{a} < {b}");
                }
                else
                {
                    Console.WriteLine("Ты никогда не увидишь этот текст");
                }
            }
        }
    }
}
