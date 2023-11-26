using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZavgorodnyayaZA.Sprint5.Task7.V22.Lib
{
    public class DataService : ISprint5Task7V22
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = @"C:\DataSprint5\InPutDataFileTask7V22.txt";
            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;
            if (fileExists) File.Delete(pathSaveFile);
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    File.WriteAllText(pathSaveFile, line.Replace('.', '#').Replace(',', '#').Replace('!', '#').Replace('?', '#').Replace('-', '#') + Environment.NewLine);
                }
            }
            return pathSaveFile;

        }
    }
}
