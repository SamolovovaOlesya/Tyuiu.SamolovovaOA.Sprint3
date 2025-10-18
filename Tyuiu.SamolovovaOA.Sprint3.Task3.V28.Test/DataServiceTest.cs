using Tyuiu.SamolovovaOA.Sprint3.Task3.V28.Lib;

namespace Tyuiu.SamolovovaOA.Sprint3.Task3.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ReplaceDigitsWithR()
        {
            var ds = new DataService();
            string src = "f35hyt t4j 3gkg45";
            string expected = "frrhyt trj rgkgrr";
            string actual = ds.ReplaceNumOnChar(src, 'r');
            Assert.AreEqual(expected, actual);
        }
    }
}
