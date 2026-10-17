using Tyuiu.VorontsovAS.Sprint1.Task6.V10.Lib;

namespace Tyuiu.VorontsovAS.Sprint1.Task6.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string text = "EEE EE EEE";
            string exp = "EE EE EE";
            var res = ds.DeleteMiddleLetter(text);
            Assert.AreEqual(exp, res);
        }
    }
}
