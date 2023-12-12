using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tyuiu.BrukhovAA.Sprint7.Project.V8.Lib
{
    public class DataService
    {
        public string[,] LoadFromFileData(string filePath)//метод, который открывает матрицу из файла по заданному пути
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int colums = lines[0].Split(';').Length;

            string[,] array = new string[rows, colums];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < colums; c++)
                {
                    array[r, c] = line_r[c];
                }
            }

            return array;
        }
    }
}
