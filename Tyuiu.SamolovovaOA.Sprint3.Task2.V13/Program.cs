using Tyuiu.SamolovovaOA.Sprint3.Task2.V13.Lib;
namespace Tyuiu.SamolovovaOA.Sprint3.Task2.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            double t = 0.7;
            int start = 1;
            int stop = 10;

            double result = ds.GetSumSeries(t, start, stop);

            Console.WriteLine($"Результат вычисления суммы ряда при t = {t}: {result}");
            Console.ReadKey();
        }
    }
}
