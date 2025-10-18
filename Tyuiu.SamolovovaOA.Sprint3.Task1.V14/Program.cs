using Tyuiu.SamolovovaOA.Sprint3.Task1.V14.Lib;
namespace Tyuiu.SamolovovaOA.Sprint3.Task1.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            double value = 0.7;
            int startValue = 1;
            int stopValue = 14;

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                *");
            Console.WriteLine("*******************************************************************");
            Console.WriteLine($"t = {value}");
            Console.WriteLine("*******************************************************************");

            double result = ds.GetSumSeries(value, startValue, stopValue);

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                      *");
            Console.WriteLine("*******************************************************************");
            Console.WriteLine($"Сумма ряда = {result}");
            Console.WriteLine("*******************************************************************");
            Console.ReadKey();
        }
    }
}
