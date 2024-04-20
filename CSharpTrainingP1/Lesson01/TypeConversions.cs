using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01
{
    class TypeConversions
    {
        public static void Do()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = 2;

            float num1 = Convert.ToSingle(1.2345);
            float num2 = 1.2345f;
            double numD = a;
            numD = 1.1;
            a = Convert.ToInt32(numD);

            Console.WriteLine();
        }
    }
}
