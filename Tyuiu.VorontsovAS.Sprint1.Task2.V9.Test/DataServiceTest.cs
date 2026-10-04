using Tyuiu.VorontsovAS.Sprint1.Task2.V9.Lib;
namespace Tyuiu.VorontsovAS.Sprint1.Task2.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TExpressionvalid()
        {
            DataService DS = new DataService();
            int r = 3;
            double wait = 113.097;
            var res = DS.CalculateVolumeCircle(r);
            Assert.AreEqual(wait, res);
        }
    }
}
