
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YangolenkoDS.Sprint4.TaskReview.V7.Lib;

namespace Tyuiu.YangolenkoDS.Sprint4.TaskReview.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int n = 4;
            int m = 2;
            int[,] mrtx = new int[n, m];
            string str = "31415926";
            int res = ds.Calculate(n, m, str);
            int wait = 5;
            Assert.AreEqual(wait, res);
        }
    }
}
