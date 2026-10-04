using Tyuiu.VorontsovAS.Sprint1.Task1.V11.Lib;
namespace Tyuiu.VorontsovAS.Sprint1.Task1.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService DS = new DataService();
            double x = 6;
            double y = 5;
            double wait = 1;
            var res = DS.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
