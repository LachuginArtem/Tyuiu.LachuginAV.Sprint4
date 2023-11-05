using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.LachuginAV.Sprint4.Task2.V20.Lib;

namespace Tyuiu.LachuginAV.Sprint4.Task2.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService dataService = new DataService();
            int[] nums = { 4, 3, 3, 9, 5, 6, 5, 6, 4, 5, 7, 3 };
            int res = dataService.Calculate(nums), wait = 20;
            Assert.AreEqual(wait, res);
        }
    }
}