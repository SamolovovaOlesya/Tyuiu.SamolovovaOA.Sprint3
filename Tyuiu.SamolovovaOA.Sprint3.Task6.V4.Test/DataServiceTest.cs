using Tyuiu.SamolovovaOA.Sprint3.Task6.V4.Lib;

namespace Tyuiu.SamolovovaOA.Sprint3.Task6.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CountDivisorsGreaterThanNine()
        {
            var ds = new DataService();
            int expected = 8; 
            int actual = ds.GetSumTheDivisors(14, 20);
            Assert.AreEqual(expected, actual);
        }
    }
}
