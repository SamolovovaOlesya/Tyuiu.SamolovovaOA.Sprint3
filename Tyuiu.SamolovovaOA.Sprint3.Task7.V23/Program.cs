using Tyuiu.SamolovovaOA.Sprint3.Task7.V23.Lib;

namespace Tyuiu.SamolovovaOA.Sprint3.Task7.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ds = new DataService();

            int start = -5;
            int stop = 5;
            double[] values = ds.GetMassFunction(start, stop);

            Console.WriteLine("Таблица значений F(x) = 4 - 2x + (2 + cos(x)) / (2x - 2)");
            Console.WriteLine($"x\tF(x) (x от {start} до {stop}, шаг 1)");
            Console.WriteLine("----------------------------------");

            int x = start;
            foreach (var y in values)
            {
                Console.WriteLine($"{x,3}\t{y,6:F2}");
                x++;
            }
        }
    }
}
