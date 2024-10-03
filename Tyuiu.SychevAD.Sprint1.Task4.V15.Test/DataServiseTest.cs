using Tyuiu.SychevAD.Sprint1.Task4.V15.Lib;
namespace Tyuiu.SychevAD.Sprint1.Task4.V15.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(14.778 , res);
        }
    }
}