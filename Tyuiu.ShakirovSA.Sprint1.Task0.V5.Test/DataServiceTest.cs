﻿using Tyuiu.ShakirovSA.Sprint1.Task0.V5.Lib;
namespace Tyuiu.ShakirovSA.Sprint1.Task0.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(12, res);
        }
    }
}
