using System;

namespace Lesson01
{
    public class BooleanType
    {
        public static void Do()
        {
            bool b1 = 2 < 1;        // false
            bool b2 = "a" != "b";   // true

            bool flag;

            flag = true;
            Console.WriteLine($"flag = {flag}, !flag = {!flag}");
            flag = false;
            Console.WriteLine($"flag = {flag}, !flag = {!flag}");

            Console.WriteLine();

            Console.WriteLine($"true && true = {true && true}");
            Console.WriteLine($"false && true = {false && true}");
            Console.WriteLine($"true && false = {true && false}");
            Console.WriteLine($"false && false = {false && false}");

            Console.WriteLine();

            Console.WriteLine($"true || true = {true || true}");
            Console.WriteLine($"false || true = {false || true}");
            Console.WriteLine($"true || false = {true || false}");
            Console.WriteLine($"false || false = {false || false}");

            Console.WriteLine();

            Console.WriteLine($"true ^ true = {true ^ true}");
            Console.WriteLine($"false ^ true = {false ^ true}");
            Console.WriteLine($"true ^ false = {true ^ false}");
            Console.WriteLine($"false ^ false = {false ^ false}");
        }
    }
}
