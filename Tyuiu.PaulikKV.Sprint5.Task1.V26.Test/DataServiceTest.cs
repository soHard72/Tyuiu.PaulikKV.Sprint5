﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.PaulikKV.Sprint5.Task1.V26.Lib;

namespace Tyuiu.PaulikKV.Sprint5.Task1.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.PaulikKV.Sprint5\Tyuiu.PaulikKV.Sprint5.Task1.V28\bin\Debug\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
