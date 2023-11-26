using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ZavgorodnyayaZA.Sprint5.Task0.V12.Lib;

namespace Tyuiu.ZavgorodnyayaZA.Sprint5.Task0.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\iljas\source\repos\Tyuiu.ShishkovIA.Sprint5\Tyuiu.ShishkovIA.Sprint5.Task0.V12\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            Assert.IsTrue(fileExists);
        }
    }
}