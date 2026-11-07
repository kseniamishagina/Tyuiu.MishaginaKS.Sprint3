using System;
using Tyuiu.MishaginaKS.Sprint3.Task5.V30.Lib;
namespace Tyuiu.MishaginaKS.Sprint3.Task5.V30;

class Program

{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Задание #5 | Вариант 30";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #30                                                             *");
        Console.WriteLine("* Выполнила: Мишагина К. С. | Группа АСОиУб-26-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Вычислить значение функции (двойной ряд суммирования) при X = 2.        *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int x = 2;
        int startValue1 = 1;
        int stopValue1 = 3;
        int startValue2 = 1;
        int stopValue2 = 11;

        Console.WriteLine("Переменная X = " + x);
        Console.WriteLine("Старт внешнего шага (i) = " + startValue1);
        Console.WriteLine("Конец внешнего шага (i) = " + stopValue1);
        Console.WriteLine("Старт внутреннего шага (k) = " + startValue2);
        Console.WriteLine("Конец внутреннего шага (k) = " + stopValue2);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

        Console.WriteLine("Сумма ряда = " + result);

        Console.ReadKey();
    }
}
