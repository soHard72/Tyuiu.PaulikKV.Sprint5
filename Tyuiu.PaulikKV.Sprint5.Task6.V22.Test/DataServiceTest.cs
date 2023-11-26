using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.PaulikKV.Sprint5.Task6.V22.Lib;

namespace Tyuiu.PaulikKV.Sprint5.Task6.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ChechedExistsFile ()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V22.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileexists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileexists);
        }

        [TestMethod]
        public void ValidCheck()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V22.txt";
            var res = ds.LoadFromDataFile(path);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}
