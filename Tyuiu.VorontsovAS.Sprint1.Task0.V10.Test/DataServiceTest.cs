using Tyuiu.VorontsovAS.Sprint1.Task0.V10.Lib;
namespace Tyuiu.VorontsovAS.Sprint1.Task0.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService DS = new DataService();
            Assert.AreEqual(-10.5, DS.Calculate());
        }
    }
}
