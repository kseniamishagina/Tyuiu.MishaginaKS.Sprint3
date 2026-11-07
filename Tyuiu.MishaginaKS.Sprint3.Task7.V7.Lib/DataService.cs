namespace Tyuiu.MishaginaKS.Sprint3.Task7.V7.Lib;
using tyuiu.cources.programming.interfaces.Sprint3;

public class DataService : ISprint3Task7V7

{
    public double[] GetMassFunction(int startValue, int stopValue)

    {
        int len = stopValue - startValue + 1;
        double[] valueArray = new double[len];
        int count = 0;

        for (int x = startValue; x <= stopValue; x++)
        {
            if (x + 2 == 0)
            {
                valueArray[count] = 0;
            }
            else
            {
                double y = Math.Cos(x) + (Math.Cos(x) / (x + 2)) - 3 * x;
                valueArray[count] = Math.Round(y, 2);
            }
            count++;
        }

        return valueArray;
    }
}

