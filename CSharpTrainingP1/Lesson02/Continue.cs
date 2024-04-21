using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{
    public class Continue
    {
        public static void Do()
        {
            Console.Write("Какое значение нужно пропустить: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= 10; i++)
            {
                if (i == n) continue;
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i,2} x {j,2} = {i * j}");
                }
                Console.WriteLine();
            }
        }
    }
}
