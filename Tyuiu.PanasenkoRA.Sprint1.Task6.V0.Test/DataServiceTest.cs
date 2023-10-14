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
            string strTest = "Казак ехал на лошади";
            DataService ds = new DataService();
            string res = ds.CheckSymmetricalWords(strTest);
            string wait = "Казак";
            Assert.AreEqual(wait, res);
        }
    }
}
