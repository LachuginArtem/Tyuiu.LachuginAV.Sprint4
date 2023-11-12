using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection.Emit;
using Tyuiu.LachuginAV.Sprint4.Task6.V5.Lib;

namespace Tyuiu.LachuginAV.Sprint4.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            string[] cars = new string[] { "Меркурий", "Венера", "Земля", "Марс", "Юпитер", "Сатурн", "Уран", "Нептун" };
            int res = dataService.Calculate(cars), wait = 1;
            Assert.AreEqual(wait, res);
        }
    }
}