using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.PaulikKV.Sprint5.Task7.V13.Lib;

namespace Tyuiu.PaulikKV.Sprint5.Task7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile ()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V13.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileexists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileexists);
        }

        public void CheckedExistsFileOutPut()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.PaulikKV.Sprint5\Tyuiu.PaulikKV.Sprint5.Task7.V13\bin\Debug\OutPutDataFileTask7V13.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
}
