using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice02
{
    public class TowerOfHanoi
    {
        //        Задача 8. «Ханойская башня»
        //Реализовать на C# рекурсивный алгоритм игры «Ханойская башня»:

        static void Move(int number, int from, int to, int free)
        {
            if (number > 0)
            {
                Move(number - 1, from, free, to);
                Console.WriteLine("{0} => {1}", from, to);
                Move(number - 1, free, to, from);
            }
        }
        public static void Do()
        {
            Move(4, 1, 2, 3);
        }

    }
}
