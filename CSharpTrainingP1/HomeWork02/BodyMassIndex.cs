using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork02
{
    public class BodyMassIndex
    {
        //5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс
        //массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
        //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

        public static void Do()
        {
            Console.Write("Введите рост: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вес: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            double bmi = BMI(height, weight);

            Console.WriteLine($"Индекс массы тела равен: {bmi}");
        }

        static double BMI(double height, double weight)
        {
            double bmi = weight / (100 * (height * height));
            return bmi;
        }
    }
}
