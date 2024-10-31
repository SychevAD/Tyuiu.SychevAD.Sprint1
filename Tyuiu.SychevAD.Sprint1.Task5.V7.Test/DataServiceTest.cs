using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SychevAD.Sprint1.Task5.V7.Lib;

namespace Tyuiu.SychevAD.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double f = 100;
            DataService ds = new DataService();
            double res = ds.AngleToHoursMinutes(f);

            int result = Convert.ToInt32(res);

            int wait = 3;
            Assert.AreEqual(wait, result);
        }
    }
}