using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork01
{
    public class BodyMassIndex
    {
        //2. Ввести вес и рост человека.
        //Рассчитать и вывести индекс массы тела(ИМТ)
        //по формуле I=m/(h*h);
        //где m — масса тела в килограммах, h — рост в метрах.

        public static void Do()
        {
            double bmi, height, weight;

            Console.Write("Введите рост: ");
            height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вес: ");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            bmi = weight / (100 * (height * height));

            Console.WriteLine($"ИМТ = {bmi}");
            Console.ReadLine();
        }
    }
}
