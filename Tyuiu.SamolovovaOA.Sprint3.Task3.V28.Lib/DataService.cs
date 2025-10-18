using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SamolovovaOA.Sprint3.Task3.V28.Lib
{
    public class DataService : ISprint3Task3V28
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));

            string result = string.Empty;
            foreach (char ch in value)
            {
                result += char.IsDigit(ch) ? item : ch;
            }
            return result;
        }
    }
}
