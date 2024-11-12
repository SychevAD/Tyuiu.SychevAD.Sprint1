using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SychevAD.Sprint1.Task7.V14.Lib;

namespace Tyuiu.SychevAD.Sprint1.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            double wait = 2.536;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}