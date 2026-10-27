using System;
using System.Globalization;
using Tyuiu.MishaginaKS.Sprint3.Task1.V30.Lib;

namespace Tyuiu.MishaginaKS.Sprint3.Task1.V30;

class Program

{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Задание #1 | Вариант 30";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #30                                                             *");
        Console.WriteLine("* Выполнила: Мишагина К. С.                                               *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу используя цикл while, которая вычисляет сумму ряда.   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double t = 0.5;
        int start = 1;
        int stop = 12;

        Console.WriteLine($"Значение T = {t}");
        Console.WriteLine($"Старт шага = {start}");
        Console.WriteLine($"Конец шага = {stop}");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double result = ds.GetSumSeries(t, start, stop);

        Console.WriteLine($"Сумма ряда S = {result.ToString("G", CultureInfo.InvariantCulture)}");

        Console.ReadKey();
    }
}

