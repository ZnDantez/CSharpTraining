using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{
    public class DoWhile
    {
        public static void Do6()
        {
            int i = 100;

            if (i <= 10)
            {
                do
                {
                    Console.WriteLine($"{i,-3} Привет, мир!");
                    i++;
                } while (i <= 10);

            }

        }
    }
}
