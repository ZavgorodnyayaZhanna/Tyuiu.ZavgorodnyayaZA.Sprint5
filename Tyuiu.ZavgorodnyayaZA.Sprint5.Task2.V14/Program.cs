using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ZavgorodnyayaZA.Sprint5.Task2.V14.Lib;

namespace Tyuiu.ZavgorodnyayaZA.Sprint5.Task2.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Завгородняя Ж.А. | ИСПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнила: Завгородняя Жанна Алексеевна | ИСПб-23-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры. Заменить положительные элементы массива на 1,  *");
            Console.WriteLine("* отрицательные на 0. Результат сохранить в файл OutPutFileTask2.csv и    *");
            Console.WriteLine("* вывести на консоль.                                                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

            int[,] mtrx = new int[3, 3] {  { -3, -6, -3 },
                                           { 6, 8, 3 },
                                           { -6, -5, 5 } };

            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.GetUpperBound(1) + 1;

            Console.Write("Массив:{ ");
            for (int i = 0; i < mtrx.GetUpperBound(0) + 1; i++)
            {
                if (i != 0) { Console.Write("\t "); }
                Console.Write("{");
                for (int j = 0; j < mtrx.Length / (mtrx.GetUpperBound(0) + 1); j++)
                {
                    Console.Write(mtrx[i, j]);
                    if (j != mtrx.GetLength(1) - 1) { Console.Write(", "); }
                }
                Console.Write("}");
                if (i != mtrx.GetLength(0) - 1) { Console.WriteLine(","); }
            }
            Console.WriteLine("}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(mtrx);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
