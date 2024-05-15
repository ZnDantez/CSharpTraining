using System;

namespace Lesson03
{
    public class Class1
    {
        // Методы. От структур к объектам. Исключения

        #region PrintCenter

        static void PrintCenter(double msg, int offset)
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - msg.ToString().Length / 2,
                Console.WindowHeight / -offset);
            Console.WriteLine(msg);
        }

        static void PrintCenter(string msg, int offset)
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - msg.Length / 2,
                Console.WindowHeight / 2 - offset);
            Console.WriteLine(msg);
        }

        static double F(double x)
        {
            return x * x;
        }

        static double G(double x, double y)
        {
            return x + y;
        }

        #endregion

        #region Reference

        static void Swap(ref int vA, ref int vB)
        {
            Console.WriteLine($"vA = {vA}, vB = {vB}");

            int temp = vA;
            vA = vB;
            vB = temp;

            Console.WriteLine($"vA = {vA}, vB = {vB}");
        }

        #endregion

        #region Structure

        struct Worker
        {
            public string name;
            public int age;
            public int salary;

            public Worker(string name, int age, int salary)
            {
                this.name = name;
                this.age = age;
                this.salary = salary;
            }

            public string Print()
            {
                return $"Name = {name}, age = {age}, salary = {salary}";
            }
        }

        #endregion

        public static void Do()
        {
            #region TryParse

            int n = 0; //Convert.ToInt32(Console.ReadLine());

            var flag = int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine(flag ? "Данные хорошие" : "Данные плохие");

            #endregion

            Worker wk1 = new Worker()
            {
                name = "Dima",
                age = 40,
                salary = 2000
            };
            Worker wk2 = new Worker("Jenya", 23, 1000);

            Console.WriteLine(wk1.Print());

            int a = 1;
            int b = 2;

            Console.WriteLine($"a = {a}, b = {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"a = {a}, b = {b}");

            Console.ReadLine();

            double res = G(12, 33);//f(2.2)
            PrintCenter(res, 0);

            Console.ReadLine();
        }
    }
}
