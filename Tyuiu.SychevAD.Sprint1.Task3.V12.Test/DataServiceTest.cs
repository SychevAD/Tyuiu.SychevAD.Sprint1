using Tyuiu.SychevAD.Sprint1.Task3.V12.Lib;
namespace Tyuiu.SychevAD.Sprint1.Task3.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double waited = 2;
            var res = ds.TriangleArea(x, y);
            Assert.AreEqual(waited, res);
        }
    }
}