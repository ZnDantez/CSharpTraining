using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{
    public class Break
    {

        public static void Do()
        {
            Console.WriteLine("До какого числа показывать таблицу умножения: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= 10; i++)
            {
                if (i == n) break;
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i,2} x {j,3} = {i * j}");
                }
                Console.WriteLine();
            }
        }
    }
}
