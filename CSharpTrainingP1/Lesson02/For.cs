using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{
    public class For
    {
        public static void Do4()
        {
            for (int counter = 1; counter <= 100; counter++)
            {
                Console.WriteLine($"{counter,3} Привет, мир!");
            }

            Console.WriteLine();

            for (int i = 1; i <= 100; i++)
                Console.WriteLine($"{i,-3} Привет, мир!");
        }
    }
}
