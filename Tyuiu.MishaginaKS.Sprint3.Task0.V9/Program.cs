using System;
using System.Globalization;
using Tyuiu.MishaginaKS.Sprint3.Task0.V9.Lib;

namespace Tyuiu.MishaginaKS.Sprint3.Task0.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Задание #0 | Вариант 9";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнила: Мишагина К. С.                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет сумму ряда.    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x = 0.5;
            int start = 1;
            int stop = 15;

            Console.WriteLine($"Значение X = {x}");
            Console.WriteLine($"Старт шага = {start}");
            Console.WriteLine($"Конец шага = {stop}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.GetSumSeries(x, start, stop);

            Console.WriteLine($"Сумма ряда S = {result.ToString("G", CultureInfo.InvariantCulture)}");

            Console.ReadKey();
        }
    }
}