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

        double value = 0.5;
        int startValue = 1;
        int stopValue = 12;

        Console.WriteLine($"Значение T (value) = {value.ToString("G", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Старт шага (startValue) = {startValue}");
        Console.WriteLine($"Конец шага (stopValue) = {stopValue}");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double result = ds.GetSumSeries(value, startValue, stopValue);

        Console.WriteLine($"Сумма ряда S = {result.ToString("G", CultureInfo.InvariantCulture)}");

        Console.ReadKey();
    }
}