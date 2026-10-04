using Tyuiu.VorontsovAS.Sprint1.Task3.V17.Lib;
namespace Tyuiu.VorontsovAS.Sprint1.Task3.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService DS = new DataService();
            double n = 42.7874087;
            bool wait = false;
            var res = DS.ZeroCheck(n);
        }
    }
}
