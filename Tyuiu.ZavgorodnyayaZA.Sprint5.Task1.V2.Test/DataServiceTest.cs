using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ZavgorodnyayaZA.Sprint5.Task1.V2.Lib;

namespace Tyuiu.ZavgorodnyayaZA.Sprint5.Task1.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\iljas\source\repos\Tyuiu.ShishkovIA.Sprint5\Tyuiu.ShishkovIA.Sprint5.Task1.V2\bin\Debug\OutPutFileTask1.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            Assert.IsTrue(fileExists);
        }
    }
}
