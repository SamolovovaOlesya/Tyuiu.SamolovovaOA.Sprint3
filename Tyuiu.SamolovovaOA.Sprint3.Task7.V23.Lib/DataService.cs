using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SamolovovaOA.Sprint3.Task7.V23.Lib
{
    public class DataService : ISprint3Task7V23
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] result = new double[length];
            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double y;
                double denom = 2.0 * x - 2.0;

                if (Math.Abs(denom) < 1e-12)
                {
                    y = 0.0; 
                }
                else
                {
                    y = 4 - 2 * x + (2 + Math.Cos(x)) / denom;
                }

                result[index++] = Math.Round(y, 2);
            }

            return result;
        }
    }
}
