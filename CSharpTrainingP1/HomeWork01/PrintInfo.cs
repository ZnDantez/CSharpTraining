using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Support;

namespace HomeWork01
{
    public class PrintInfo
    {
        //5. а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
        //б) *Сделать задание, только вывод организовать в центре экрана.
        //в) **Сделать задание б с использованием собственных методов
        //(например, Print(string ms, int x, int y).


        public static void Do()
        {
            string name = "Сергей";
            string sname = "Попов";
            string city = "Тамбов";

            string info = $"{name} {sname}, город {city}";

            Console.WriteLine(info);

            Console.SetCursorPosition((Console.WindowWidth / 2) - (info.Length / 2), 1);

            Console.WriteLine(info);

            Sup.Print(info);
        }
    }
}
