using Tyuiu.SamolovovaOA.Sprint3.Task2.V13.Lib;

namespace Tyuiu.SamolovovaOA.Sprint3.Task2.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestGetSumSeries()
        {
            DataService ds = new DataService();
            double value = 0.7;
            int startValue = 1;
            int stopValue = 10;

            double result = ds.GetSumSeries(value, startValue, stopValue);

            Assert.AreEqual(4.063, result, 0.01);
        }
    }
}
