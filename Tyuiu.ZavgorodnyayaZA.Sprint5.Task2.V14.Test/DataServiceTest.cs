using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ZavgorodnyayaZA.Sprint5.Task2.V14.Lib;

namespace Tyuiu.ZavgorodnyayaZA.Sprint5.Task2.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\iljas\source\repos\Tyuiu.ShishkovIA.Sprint5\Tyuiu.ShishkovIA.Sprint5.Task2.V14\bin\Debug\OutPutFileTask2.csv";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            Assert.IsTrue(fileExists);
        }
    }
}
