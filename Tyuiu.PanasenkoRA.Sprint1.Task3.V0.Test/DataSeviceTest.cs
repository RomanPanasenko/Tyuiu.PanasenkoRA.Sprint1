using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PanasenkoRA.Sprint1.Task3.V0.Lib;

namespace Tyuiu.PanasenkoRA.Sprint1.Task3.V0.Test
{
    [TestClass]
    public class DataSeviceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double v1 = 5;
            double v2 = 10;
            double S = 2;
            double T = 10;
            double wait = 40;
            var res = ds.DistanceOverTime(v1, v2, T, S);
            Assert.AreEqual(wait, res);
        }
    }
}
