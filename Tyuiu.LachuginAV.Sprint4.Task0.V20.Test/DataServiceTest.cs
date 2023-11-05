using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.LachuginAV.Sprint4.Task0.V20.Lib;

namespace Tyuiu.LachuginAV.Sprint4.Task0.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultEvenArrEl()
        {
            DataService ds = new DataService();

            int[] array = new int[] { 4, 8, 7, 6, 5, 8, 2, 4, 3, 2 };

            Assert.AreEqual(24576, ds.GetMultEvenArrEl(array));
        }
    }
}
