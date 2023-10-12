using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PanasenkoRA.Sprint1.Task5.V0.Lib;

namespace Tyuiu.PanasenkoRA.Sprint1.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            int k = 1234;
            DataService ds = new DataService();
            int res = ds.Calculate(k);
            
            int wait = 2;
            Assert.AreEqual(wait, res);

        }
    }
}
