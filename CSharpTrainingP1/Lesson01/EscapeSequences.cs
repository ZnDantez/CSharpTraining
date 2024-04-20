using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01
{
    class EscapeSequences
    {
        public static void Do()
        {

            // Escape последовательности

            Console.WriteLine("Ку-ку");
            Console.WriteLine("Ку-ку");
            Console.WriteLine("Ку-ку");
            Console.WriteLine("Ку-ку");
            Console.WriteLine("Ку-ку");

            Console.Write("Ку-ку\n");
            Console.Write("Ку-ку\n");
            Console.Write("Ку-ку\n");
            Console.Write("Ку-ку\n");
            Console.Write("Ку-ку\n");

            Console.WriteLine("Ку-ку\nКу-ку\nКу-ку\nКу-ку\nКу-ку\n");

            Console.Write(@"Ку-ку
            Ку-ку
            Ку-ку
            Ку-ку
            Ку-ку");
        }
    }
}
