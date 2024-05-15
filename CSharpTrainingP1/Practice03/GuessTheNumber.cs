﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice03
{
    public class GuessTheNumber
    {
        //        Задача 4. Игра «Угадай число».
        //Игра «Угадай число». Метод половинного деления.
        //Написать игру «Угадай число». Компьютер загадывает число в диапазоне от 1 до 100, а человек за
        //ограниченное число попыток должен угадать его.Количество попыток вычисляется по формуле
        //i = log2N + 1

        public static void Do()
        {
            int min = 1;
            int max = 100;
            int maxCount = (int)Math.Log(max - min + 1, 2) + 1;
            int count = 0;
            Random rnd = new Random();
            int guessNumber = rnd.Next(min, max);
            Console.WriteLine("Компьютер загадал число от {0} до {1}." +
                "Попробуйте угадать его за {2} попыток", min, max, maxCount);
            int n;
            do
            {
                count++;
                Console.Write("{0} попытка. Введите число:", count);
                n = int.Parse(Console.ReadLine());
                if (n > guessNumber) Console.WriteLine("Перелет!");
                if (n < guessNumber) Console.WriteLine("Недолет!");
            }
            while (count < maxCount && n != guessNumber);
            if (n == guessNumber) Console.WriteLine("Поздравляю! Вы угадали число за {0} попыток", count);
            else Console.WriteLine("Неудача. Попробуйте еще раз");
        }

    }
}
