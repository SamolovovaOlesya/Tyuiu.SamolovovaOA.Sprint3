using Tyuiu.SamolovovaOA.Sprint3.Task3.V28.Lib;

namespace Tyuiu.SamolovovaOA.Sprint3.Task3.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value = "f35hyt t4j 3gkg45";
            char replaceChar = 'r';

            var ds = new DataService();
            string result = ds.ReplaceNumOnChar(value, replaceChar);

            Console.WriteLine($"Исходная строка: {value}");
            Console.WriteLine($"Результат:       {result}");
        }
    }
}