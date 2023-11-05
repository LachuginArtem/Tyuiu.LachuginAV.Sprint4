using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.LachuginAV.Sprint4.Task1.V5.Lib;

namespace Tyuiu.LachuginAV.Sprint4.Task1.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int[] array = new int[15];

            Console.Title = "Спринт #4 | Выполнил: Лачугин А.В. | АСОиУБ-23-3";
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* Спринт #4" + String.Concat(Enumerable.Repeat(" ", 63)) + "*");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #1" + String.Concat(Enumerable.Repeat(" ", 62)) + "*");
            Console.WriteLine("* Вариант 5" + String.Concat(Enumerable.Repeat(" ", 63)) + "*");
            Console.WriteLine("* Выполнил: Лачугин Артем Викторович | АСОиУБ-23-3" + String.Concat(Enumerable.Repeat(" ", 26)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* УСЛОВИЕ:" + String.Concat(Enumerable.Repeat(" ", 64)) + "*");
            Console.WriteLine("* Написать програму, которая суммирует количевство четных чисел в массиве *");
            Console.WriteLine("* и печатает их на экран.                                                 *");
            Console.WriteLine("*" + String.Concat(Enumerable.Repeat(" ", 73)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:" + String.Concat(Enumerable.Repeat(" ", 56)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите {0}-й элемент", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine($"* Результат:{String.Concat(Enumerable.Repeat(" ", 62))}*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));

            Console.WriteLine($"Сумма четных элементов массива: \n{ds.Calculate(array)}");
            Console.ReadKey();
        }
    }
}