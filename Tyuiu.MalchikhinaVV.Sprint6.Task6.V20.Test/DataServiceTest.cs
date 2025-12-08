using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

using Tyuiu.MalchikhinaVV.Sprint6.Task6.V20.Lib;
namespace Tyuiu.MalchikhinaVV.Sprint6.Task6.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Home\source\repos\Tyuiu.MalchikhinaVV.Sprint6\InPutDataFileTask6V20.txt";
            string wait = "dKOPBC IqjpIlKAaSCBuaQUU GPeEqZo FPsrQHsImzbTBckw NgAfitECn";
            string res = ds.CollectTextFromFile(path);
            Assert.AreEqual(wait, res);
        }
    }
}
