using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01
{
    public class Variables
    {

        public static void Do()
        {

            var name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}!");
            Console.WriteLine("Привет, " + name + "!");
            Console.WriteLine("Привет, {0}!", name);

            Console.ReadLine();
        }


    }
}
