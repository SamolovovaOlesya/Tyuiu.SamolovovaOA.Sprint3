using Tyuiu.SamolovovaOA.Sprint3.Task5.V17.Lib;

namespace Tyuiu.SamolovovaOA.Sprint3.Task5.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestNestedSum()
        {
            var ds = new DataService();
            int x = 2;
            double expected = 0;
            for (int i = 1; i <= 3; i++)
            {
                for (int k = 1; k <= 12; k++)
                {
                    expected += Math.Sin(k) + Math.Pow(x, 2);
                }
            }
            expected = Math.Round(expected, 3);
            double actual = ds.GetSumSumSeries(x, 1, 1, 3, 12);
            Assert.AreEqual(expected, actual);
        }
    }
}
