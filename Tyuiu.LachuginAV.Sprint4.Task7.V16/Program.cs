using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LachuginAV.Sprint4.Task7.V16.Lib;

namespace Tyuiu.LachuginAV.Sprint4.Task7.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService dataService = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Лачугин А.В. | АСОиУб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Лачугин Артем Викторович | АСОиУб-23-3                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"382976421897948\". Преобразуйте ее в*");
            Console.WriteLine("* матрицу 5 на 3 и подсчитайте произведение  четных чисел.                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int rows = 5, columns = 3;
            int[,] mtrx = new int[rows, columns];

            string value = "382976421897948";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    mtrx[i, j] = int.Parse(value.Substring(i * columns + j, 1));
                }
            }

            Console.Write("Массив:{ ");
            for (int i = 0; i < mtrx.GetUpperBound(0) + 1; i++)
            {
                if (i != 0) { Console.Write("\t "); }
                Console.Write("{");
                for (int j = 0; j < mtrx.Length / (mtrx.GetUpperBound(0) + 1); j++)
                {
                    Console.Write(mtrx[i, j]);
                    if (j != mtrx.GetLength(1) - 1) { Console.Write(", "); }
                }
                Console.Write("}");
                if (i != mtrx.GetLength(0) - 1) { Console.WriteLine(","); }
            }
            Console.WriteLine("}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = dataService.Calculate(rows, columns, value);

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}