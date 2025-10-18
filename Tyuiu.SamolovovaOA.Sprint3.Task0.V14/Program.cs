using Tyuiu.SamolovovaOA.Sprint3.Task0.V14.Lib;
namespace Tyuiu.SamolovovaOA.Sprint3.Task0.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("*************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("*************************************************");

            int value = 3;
            int startValue = 1;
            int stopValue = 3;

            Console.WriteLine("Переменная X = " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);
            Console.WriteLine();
            Console.WriteLine("*************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:");
            Console.WriteLine("*************************************************");

            Console.WriteLine("Произведение ряда = " + ds.GetMultiplySeries(value, startValue, stopValue));
        }
    }
}