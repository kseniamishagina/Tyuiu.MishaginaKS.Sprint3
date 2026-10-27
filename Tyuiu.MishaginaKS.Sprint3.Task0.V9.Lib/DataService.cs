namespace Tyuiu.MishaginaKS.Sprint3.Task0.V9.Lib;

using tyuiu.cources.programming.interfaces.Sprint3;

using System;


public class DataService : ISprint3Task0V9
{
    public double GetSumSeries(double value, int startValue, int stopValue)

    {
        double sum = 0;

        for (int i = startValue; i <= stopValue; i++)
        {

            double inner = 1.0 / (3.0 + Math.Pow(value, i));
            sum += Math.Pow(inner, i);
        }

        return Math.Round(sum, 3);
    }
}