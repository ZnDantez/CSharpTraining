using System;

namespace HomeWork03
{
    public class Complex
    {
        //1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.
        //Продемонстрировать работу структуры.
        //б) Дописать класс Complex, добавив методы вычитания и произведения чисел.
        //Проверить работу класса.
        //в) Добавить диалог с использованием switch демонстрирующий работу класса.

        double a;
        double b;

        Complex()
        {
            this.a = 0;
            this.b = 1;
        }
        Complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public override string ToString()
        {
            if (Convert.ToString(a).Length == 1 && Convert.ToString(a).Length == 1)
                return $"|{a}+{b}i|";
            else
                return $"|({a:f2})+({b:f2})i|";
        }

        static Complex Addition(Complex c1, Complex c2)
        {
            Complex c = new Complex();

            c.a = c1.a + c2.a;
            c.b = c1.b + c2.b;

            return c;
        }
        static Complex Subtraction(Complex c1, Complex c2)
        {
            Complex c = new Complex();

            c.a = c1.a - c2.a;
            c.b = c1.b - c2.b;

            return c;
        }
        static Complex Multiplication(Complex c1, Complex c2)
        {
            Complex c = new Complex();

            c.a = (c1.a * c2.a) - (c1.b * c2.b);
            c.b = (c1.b * c2.a) + (c1.a * c2.b);

            return c;
        }
        static Complex Division(Complex c1, Complex c2)
        {
            Complex c = new Complex();

            c.a = ((c1.a * c2.a) + (c1.b * c2.b)) / (Math.Pow(c2.a, 2) + Math.Pow(c2.b, 2));
            c.b = ((c1.b * c2.a) - (c1.a * c2.b)) / (Math.Pow(c2.a, 2) + Math.Pow(c2.b, 2));

            return c;
        }

        public static void Do()
        {
            Complex a = new Complex(5, 6);
            Complex b = new Complex(3, 5);

            Complex c = Addition(a, b);
            Complex d = Subtraction(a, b);
            Complex e = Multiplication(a, b);
            Complex f = Division(a, b);

            Console.WriteLine($"Даны два комплексных числа: {a.ToString()} и {b.ToString()}");
            Console.WriteLine("Выберите сложение, вычитание, умножение, или деление" +
                "с помощью +, -, * и / соответственно");

            char symbol = '+';

            while (symbol == '+' || symbol == '-' || symbol == '*' || symbol == '/')
            {
                try
                {
                    symbol = Convert.ToChar(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Вы должны ввести один из символов: +, -, *, /, или любой другой для выхода");
                }
                
                switch (symbol)
                {
                    case '+': Console.WriteLine($"{a.ToString()} + {b.ToString()} = {c.ToString()}"); break;
                    case '-': Console.WriteLine($"{a.ToString()} - {b.ToString()} = {d.ToString()}"); break;
                    case '*': Console.WriteLine($"{a.ToString()} * {b.ToString()} = {e.ToString()}"); break;
                    case '/': Console.WriteLine($"{a.ToString()} + {b.ToString()} = {f.ToString()}"); break;
                }
            }

        }
    }
}
