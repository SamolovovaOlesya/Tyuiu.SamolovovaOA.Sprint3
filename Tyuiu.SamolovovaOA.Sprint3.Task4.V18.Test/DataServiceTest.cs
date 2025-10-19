using Tyuiu.SamolovovaOA.Sprint3.Task4.V18.Lib;

namespace Tyuiu.SamolovovaOA.Sprint3.Task4.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CalculateSum_CorrectResult()
        {
            var ds = new DataService();
            double expected = Math.Round(Math.Tan(-5) + Math.Tan(-4) + Math.Tan(-3) + Math.Tan(-2) + Math.Tan(-1), 3);
            double actual = ds.Calculate(-5, 5);
            Assert.AreEqual(expected, actual);
        }
    }
}
