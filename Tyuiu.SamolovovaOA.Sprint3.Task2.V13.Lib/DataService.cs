using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SamolovovaOA.Sprint3.Task2.V13.Lib
{
    public class DataService : ISprint3Task2V13
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double s = 0;
            int k = startValue;
            do
            {
                s += (Math.Pow(value, k) + (2.0 / (k + 1))) * Math.Sin(value);
                k++;
            } while (k <= stopValue);
            return Math.Round(s, 3);
        }
    }
}
