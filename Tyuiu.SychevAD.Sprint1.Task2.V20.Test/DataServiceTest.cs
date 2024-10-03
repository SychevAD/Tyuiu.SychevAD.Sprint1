using Tyuiu.SychevAD.Sprint1.Task2.V20.Lib;

namespace Tyuiu.SychevAD.Sprint1.Task2.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            int y = 1;
            var res = ds.Sqr(x, y);
            Assert.AreEqual(5, res);
        }
    }
}