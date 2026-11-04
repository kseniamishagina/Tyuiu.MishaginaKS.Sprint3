using System;
using Tyuiu.MishaginaKS.Sprint3.Task3.V21.Lib;
namespace Tyuiu.Sprint3.Task3.V21;

class Program

{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Задание #3 | Вариант 21";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #21                                                             *");
        Console.WriteLine("* Выполнила: Мишагина К.С. | Группа АСОиУБ-26-1                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Используя цикл foreach заменить цифры на букву e в строке:              *");
        Console.WriteLine("* f3g5ht g4j 34kg4                                                        *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string value = "f3g5ht g4j 34kg4";
        char item = 'e';

        Console.WriteLine("Исходная строка = " + value);
        Console.WriteLine("Символ для замены = " + item);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string result = ds.ReplaceNumOnChar(value, item);

        Console.WriteLine("Конечная строка = " + result);

        Console.ReadKey();
    }
}

