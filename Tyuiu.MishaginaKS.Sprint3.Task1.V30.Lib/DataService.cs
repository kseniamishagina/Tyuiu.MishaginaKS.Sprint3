using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MishaginaKS.Sprint3.Task1.V30.Lib;


public class DataService : ISprint3Task1V30
{
    public double GetSumSeries(double value, int startValue, int stopValue)

    {
        double sum = 0;
        int k = startValue;

        while (k <= stopValue)

        {
            double term = Math.Pow(value, k) + (5.0 / (k + 4.0));

            sum += term * Math.Sin(value);

            k++;
        }

        return Math.Round(sum, 3);
    }
}

    

