using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice02
{
    public class ProgramExecutionTime
    {
        //        Задача 5. Учимся подсчитывать эффективность программы
        //Для этого давайте научимся подсчитывать время выполнения программы.Решим задачу нахождения
        //простых чисел в диапазоне от 1 до 1000000. Напишем метод проверки, является ли число простым, и
        //используем его для подсчёта количества чисел.В начале цикла сохраним текущее время, по выходу
        //из цикла вычтем текущее время из сохранённого и выведем результат на экран.

        static bool IsSimple(int n)
        {
            for (int i = 2; i <= n / 2; i++)
                if (n % i == 0) return false;
            return true;
        }

        public static void Do()
        {
            DateTime start = DateTime.Now;
            int k = 0;
            for (int i = 2; i < 1000000; i++)
                if (IsSimple(i))
                {
                    k++;
                    Console.WriteLine("{0} {1}", k, i);
                }
            Console.WriteLine(k);
            Console.WriteLine(DateTime.Now - start);
        }

        //        На самом деле в методе определения простоты числа можно заменить условие на i<=Math.Sqrt(n).
        //Создайте новый метод с новым условием.Подсчитайте время выполнения программы с
        //использованием двух различных методов.

    }
}
