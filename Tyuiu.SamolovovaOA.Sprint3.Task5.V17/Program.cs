using Tyuiu.SamolovovaOA.Sprint3.Task5.V17.Lib;

namespace Tyuiu.SamolovovaOA.Sprint3.Task5.V17
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            var ds = new DataService();
            int x = 2;
            double result = ds.GetSumSumSeries(x, 1, 3, 1, 12);

            Console.WriteLine($"Результат вычисления при x = {x}: {result}");
        }
    }
}