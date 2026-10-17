using Tyuiu.VorontsovAS.Sprint1.Task7.V18.Lib;

namespace Tyuiu.VorontsovAS.Sprint1.Task7.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            var res = ds.Calculate(x, y);
            double exp = 1.913;
            Assert.AreEqual(exp, res);
        }
    }
}
