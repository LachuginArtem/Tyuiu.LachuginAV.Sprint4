using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LachuginAV.Sprint4.Task3.V16.Lib;

namespace Tyuiu.LachuginAV.Sprint4.Task3.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int[,] numsArray = new int[,] { { 5, 8, 5, 8, 4 },
                                            { 2, 3, 4, 6, 3 },
                                            { 1, 1, 2, 9, 9 },
                                            { 6, 7, 4, 1, 2 },
                                            { 5, 7, 1, 8, 7 } };
            int res = dataService.Calculate(numsArray), wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}