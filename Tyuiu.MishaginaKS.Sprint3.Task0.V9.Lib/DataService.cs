namespace Tyuiu.MishaginaKS.Sprint3.Task0.V9.Lib;

using tyuiu.cources.programming.interfaces.Sprint3;

using System;


    public class DataService

    {

    public double GetSumSeries(double x)

    {
            double sum = 0;

            for (int i = 1; i <= 15; i++)

            {

                double inner = 1.0 / (3.0 + Math.Pow(x, i));

                sum += Math.Pow(inner, i);
            }

            return Math.Round(sum, 3);
        }

}
