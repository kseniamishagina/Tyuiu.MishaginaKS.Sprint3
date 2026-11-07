namespace Tyuiu.MishaginaKS.Sprint3.Task5.V30.Lib;
using tyuiu.cources.programming.interfaces.Sprint3;
using System;

public class DataService : ISprint3Task5V30

{
    public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)

    {
        double sum = 0;

        for (int i = startValue1; i <= stopValue1; i++)

        {
            for (int k = startValue2; k <= stopValue2; k++)

            {
                sum += Math.Pow(x, 3) - k + x;
            }
        }

        return sum;
    }
}
