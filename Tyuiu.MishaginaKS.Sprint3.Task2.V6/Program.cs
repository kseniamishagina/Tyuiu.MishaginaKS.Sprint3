using System;
using System.Globalization;
using Tyuiu.MishaginaKS.Sprint3.Task2.V6.Lib;

namespace Tyuiu.MishaginaKS.Sprint3.Task2.V6;

class Program

{
    static void Main(string[] args)

    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Задание #2 | Вариант 6";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #6                                                              *");
        Console.WriteLine("* Выполнила: Мишагина К. С.                                               *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет        *");
        Console.WriteLine("* произведение ряда по формуле при a = 0.25                               *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double value = 0.25;
        int startValue = 1;
        int stopValue = 10;

        Console.WriteLine($"Значение A (value) = {value.ToString("G", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Старт шага (startValue) = {startValue}");
        Console.WriteLine($"Конец шага (stopValue) = {stopValue}");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double result = ds.GetMultiplySeries(value, startValue, stopValue);

        Console.WriteLine($"Произведение ряда P = {result.ToString("G", CultureInfo.InvariantCulture)}");

        Console.ReadKey();
    }
}

