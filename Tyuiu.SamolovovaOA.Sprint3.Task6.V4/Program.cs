using Tyuiu.SamolovovaOA.Sprint3.Task6.V4.Lib;

namespace Tyuiu.SamolovovaOA.Sprint3.Task6.V4;
internal class Program
{
    static void Main(string[] args)
    {
        var ds = new DataService();
        int start = 14, stop = 20;
        int result = ds.GetSumTheDivisors(start, stop);

        Console.WriteLine($"Результат: {result}");
    }
}