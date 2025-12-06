using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MalchikhinaVV.Sprint6.Task0.V14.Lib;
namespace Tyuiu.MalchikhinaVV.Sprint6.Task0.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = -0.444;
            Assert.AreEqual(wait, res);
        }
    }
}
