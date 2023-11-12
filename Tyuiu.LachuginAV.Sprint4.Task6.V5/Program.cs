using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LachuginAV.Sprint4.Task6.V5.Lib;

namespace Tyuiu.LachuginAV.Sprint4.Task6.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService dataService = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Лачугин. А.В. | АСОиУб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Лачугин Артем Викторович | АСОиУб-23-3                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [\"Меркурий\", \"Венера\", \"Земля\", \"Марс\",    *");
            Console.WriteLine("* \"Юпитер\", \"Сатурн\", \"Уран\", \"Нептун\"] используя класс Array подсчитайте количество *");
            Console.WriteLine("* элементов, длина которых равна 5.                                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string[] cars = new string[] { "Меркурий", "Венера", "Земля", "Марс", "Юпитер", "Сатурн", "Уран", "Нептун" };

            Console.Write("Массив: {");
            for (int i = 0; i < cars.Length; i++)
            {
                Console.Write(cars[i]);
                if (i != cars.Length - 1) { Console.Write(", "); }
            }
            Console.WriteLine("}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = dataService.Calculate(cars);

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}