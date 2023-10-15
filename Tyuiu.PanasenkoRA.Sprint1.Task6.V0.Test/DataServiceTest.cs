using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PanasenkoRA.Sprint1.Task6.V0.Lib;

namespace Tyuiu.PanasenkoRA.Sprint1.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "казак";
            DataService ds = new DataService();
            string res = ds.CheckSymmetricalWords(strTest);
            string wait = "казак";
            Assert.AreEqual(wait, res);
        }
    }
}
