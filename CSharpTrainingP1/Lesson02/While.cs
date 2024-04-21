using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{
    public class While
    {
        public static void Do5()
        {
            int i = 1;

            while (i <= 10)
            {
                Console.WriteLine($"{i,2} Привет, мир!");
                i++;
            }
        }
    }
}
