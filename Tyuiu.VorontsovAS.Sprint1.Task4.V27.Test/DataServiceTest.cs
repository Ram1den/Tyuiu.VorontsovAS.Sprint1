using Tyuiu.VorontsovAS.Sprint1.Task4.V27.Lib;
namespace Tyuiu.VorontsovAS.Sprint1.Task4.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService DS = new DataService();
            double x = 0;
            double y = 4;
            double wait = -0.5;
            var res = DS.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
