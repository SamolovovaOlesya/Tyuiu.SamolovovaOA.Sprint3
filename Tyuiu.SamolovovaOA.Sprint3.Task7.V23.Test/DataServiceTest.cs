using Tyuiu.SamolovovaOA.Sprint3.Task7.V23.Lib;

namespace Tyuiu.SamolovovaOA.Sprint3.Task7.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void GetMassFunction_CorrectValues()
        {
            var ds = new DataService();
            double[] expected = new double[]
            {
                13.81, 11.87, 9.87, 7.74, 5.36, 2.50, 0.00, 0.79, -1.75, -3.78, -5.71
            };

            double[] actual = ds.GetMassFunction(-5, 5);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
