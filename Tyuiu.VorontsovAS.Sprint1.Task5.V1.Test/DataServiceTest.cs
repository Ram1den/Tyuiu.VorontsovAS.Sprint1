using Tyuiu.VorontsovAS.Sprint1.Task5.V1.Lib;
namespace Tyuiu.VorontsovAS.Sprint1.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService DS = new DataService();
            double x1 = 0;
            double y1 = 4;
            double x2 = 3;
            double y2 = 0;
            var res = DS.DistanceBetweenDots(x1, y1, x2, y2);
            int wait = 5;
            Assert.AreEqual(wait, res);
        }
    }
}
