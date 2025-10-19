using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SamolovovaOA.Sprint3.Task6.V4.Lib
{
    public class DataService : ISprint3Task6V4
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            if (startValue > stopValue)
                (startValue, stopValue) = (stopValue, startValue);

            int total = 0;

            for (int n = startValue; n <= stopValue; n++)
            {
                int m = Math.Abs(n);
          
                for (int d = 10; d <= m; d++)
                {
                    if (m % d == 0) total++;
                }
            }

            return total;
        }
    }
}
