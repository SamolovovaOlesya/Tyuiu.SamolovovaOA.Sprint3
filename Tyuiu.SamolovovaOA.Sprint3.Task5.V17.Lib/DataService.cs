using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SamolovovaOA.Sprint3.Task5.V17.Lib
{
    public class DataService : ISprint3Task5V17
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double y = 0.0;
            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    y += Math.Sin(k) + Math.Pow(x, 2);
                }
            }
            return Math.Round(y, 3);
        }
    }
}
