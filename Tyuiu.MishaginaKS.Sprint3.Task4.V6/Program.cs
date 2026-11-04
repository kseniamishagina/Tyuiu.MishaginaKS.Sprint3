using System;
using Tyuiu.MishaginaKS.Sprint3.Task4.V6.Lib;

namespace Tyuiu.MishaginaKS.Sprint3.Task4.V6;

class Program
{
    static void Main(string[] args)

    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Задание #4 | Вариант 6";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #6                                                              *");
        Console.WriteLine("* Выполнила: Мишагина К. С. | Группа АСОиУб-26-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* На отрезке от -5 до 5 вычислить значение функции y=x/(cos(x)-sin(x)).   *");
        Console.WriteLine("* При х = 0 прервать цикл. Полученные значения суммировать.               *");
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

        double result = ds.Calculate(startValue, stopValue);

        Console.WriteLine("Сумма значений функции = " + result);

        Console.ReadKey();
    }
}

