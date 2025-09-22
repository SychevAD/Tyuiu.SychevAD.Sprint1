using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SychevAD.Sprint1.Task6.V10.Lib;

namespace Tyuiu.SychevAD.Sprint1.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string value = "��� ���� �����, �����������";
            var res = ds.DeleteMiddleLetter(value);
            Assert.AreEqual("�� ���� �����, ����������", res);
        }
    }
}