using System;
using Tyuiu.MishaginaKS.Sprint3.Task7.V7.Lib;

namespace Tyuiu.MishaginaKS.Sprint3.Task7.V7;


class Program

{
    static void Main(string[] args)

    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Задание #7 | Вариант 7";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #7                                                              *");
        Console.WriteLine("* Выполнила: Мишагина К. С. | Группа АСОиУб-26-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:           *");
        Console.WriteLine("* F(x) = cos(x) + cos(x)/(x + 2) - 3x в диапазоне [-5; 5] с шагом 1.      *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int startValue = -5;
        int stopValue = 5;

        Console.WriteLine("Старт шага = " + startValue);
        Console.WriteLine("Конец шага = " + stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double[] valueArray = ds.GetMassFunction(startValue, stopValue);

        Console.WriteLine("+----------+----------+");
        Console.WriteLine("|    X     |   f(x)   |");
        Console.WriteLine("+----------+----------+");

        for (int i = 0; i < valueArray.Length; i++)

        {
            Console.WriteLine("| {0,6:g}   |  {1,6:f2}  |", startValue, valueArray[i]);
            startValue++;
        }

        Console.WriteLine("+----------+----------+");
        Console.ReadKey();
    }
}

