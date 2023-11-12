using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LachuginAV.Sprint4.Task7.V16.Lib;

namespace Tyuiu.LachuginAV.Sprint4.Task7.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            string str = "382976421897948";
            int rows = 5, columns = 3;
            int[,] ints = new int[rows, columns];
            int res = dataService.Calculate(rows, columns, str), wait = 196608;
            Assert.AreEqual(wait, res);
        }
    }
}