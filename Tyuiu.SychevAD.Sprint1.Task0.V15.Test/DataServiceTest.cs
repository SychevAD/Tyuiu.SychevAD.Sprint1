using Tyuiu.SychevAD.Sprint1.Task0.V15.Lib;

namespace Tyuiu.SychevAD.Sprint1.Task0.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(24, res);

        }
    }
}