using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SamolovovaOA.Sprint3.Task4.V18.Lib
{
    public class DataService : ISprint3Task4V18
    {
        public double Calculate(int startValue, int stopValue)
        {
            double sum = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0) break;
                sum += Math.Sin(x) / Math.Cos(x);
            }
            return Math.Round(sum, 3);
        }
    }
}
