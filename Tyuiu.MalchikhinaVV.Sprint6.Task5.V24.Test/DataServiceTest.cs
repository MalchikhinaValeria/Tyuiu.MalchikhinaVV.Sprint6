using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.MalchikhinaVV.Sprint6.Task5.V24.Lib;
namespace Tyuiu.MalchikhinaVV.Sprint6.Task5.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();

            string path = @"C:\Users\Home\source\repos\Tyuiu.MalchikhinaVV.Sprint6\InPutFileTask5V24.txt";
            double[] res = ds.LoadFromDataFile(path);
            double[] wait = { 0, 0};
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
