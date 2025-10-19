using Tyuiu.SamolovovaOA.Sprint3.Task4.V18.Lib;

namespace Tyuiu.SamolovovaOA.Sprint3.Task4.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ds = new DataService();
            int start = -5;
            int stop = 5;
            double result = ds.Calculate(start, stop);

            Console.WriteLine($"Сумма sin(x)/cos(x) на отрезке [{start}; {stop}] (при x=0 прерывание): {result}");
        }
    }
}