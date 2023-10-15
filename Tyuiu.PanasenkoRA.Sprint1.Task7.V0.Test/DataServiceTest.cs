using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PanasenkoRA.Sprint1.Task7.V0.Lib;

namespace Tyuiu.PanasenkoRA.Sprint1.Task7.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 1;
            double b = 1;
            double c = 2;
            double wait = 1;
            var res = ds.Calculate(a, b, c);
            Assert.AreEqual(wait, res);
        }
    }
}
