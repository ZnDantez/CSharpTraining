using System;

namespace HomeWork01
{
    public class Questionnaire
    {
        //1. Написать программу «Анкета».
        //Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).
        //В результате вся информация выводится в одну строчку:

        //а) используя склеивание;
        //б) используя форматированный вывод;
        //в) используя вывод со знаком $.

        public static void Do()
        {
            string name, sname;
            int age;
            double height, weight;

            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            sname = Console.ReadLine();
            Console.Write("Введите возраст: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите рост: ");
            height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вес: ");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"{name} {sname}. Возраст: {age}. Рост: {height}. Вес: {weight}");
        }
    }
}
