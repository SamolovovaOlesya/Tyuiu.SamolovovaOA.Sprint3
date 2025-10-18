using Tyuiu.SamolovovaOA.Sprint3.Task0.V14.Lib;

namespace Tyuiu.SamolovovaOA.Sprint3.Task0.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void GetMultiplySeries()
        {
            DataService ds = new DataService();

            int value = 3;
            int startValue = 1;
            int stopValue = 3;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 14400; 

            Assert.AreEqual(wait, res, 0.001);
        }
    }
}
