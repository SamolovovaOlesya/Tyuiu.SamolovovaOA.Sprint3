using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SamolovovaOA.Sprint3.Task0.V14.Lib
{
    public class DataService : ISprint3Task0V14
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            int n = 2;
            double p = 1.0;
            for (int k = 1; k <= 5; k++)
            {
                // (1 / k^n)^(-1) = k^n
                p *= Math.Pow(1.0 / Math.Pow(k, n), -1);
            }
            return Math.Round(p, 3);
        }
    }
}
