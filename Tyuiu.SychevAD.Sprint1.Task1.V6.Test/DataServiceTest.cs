using Tyuiu.SychevAD.Sprint1.Task1.V6.Lib;

namespace Tyuiu.SychevAD.Sprint1.Task1.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Double x = 2;
            Double y = 1;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1, res);
        }
    }
}