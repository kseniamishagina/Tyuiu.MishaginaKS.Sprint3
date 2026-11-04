namespace Tyuiu.MishaginaKS.Sprint3.Task4.V6.Lib;
using tyuiu.cources.programming.interfaces.Sprint3;

public class DataService : ISprint3Task4V6
{
    public double Calculate(int startValue, int stopValue)

    {
        double sum = 0;

        for (int x = startValue; x <= stopValue; x++)

        {
            if (x == 0)
            {
                break;
            }

            sum += (double)x / (Math.Cos(x) - Math.Sin(x));
        }

        return Math.Round(sum, 3);
    }
}
    

