using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice01
{
    class Exchange
    {

        //Задача 3. Обменять значениями две переменные.


        public static void Do()
        {
            int a = 10; // Присваиваем начальное значение
            int b = 20; // Присваиваем начальное значение
            int t = a; // В t запоминаем значение a
            a = b; // В a записываем b
            b = t; // В b записываем сохраненное a
        }

    }
}
