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
        public string[,] LoadFromFileData(string filePath)//метод, который загружает матрицу из файла по заданному пути
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');//меняем переход на новую строку на каретку
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);//Разделяем строки по кареткам и закидываем в массив

            int rows = lines.Length;
            int colums = lines[0].Split(';').Length;//находим количество элементов в строке с разделение в виде ;

            string[,] DataBase = new string[rows, colums];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');//помещаем значения из строк в массив по разделителю
                for (int c = 0; c < colums; c++)
                {
                    DataBase[r, c] = line_r[c];//заполняем им матрицу
                }
            }

            return DataBase;
        }
        public string SearchForString(string[,] DataBase, string SearchingData)//метод, который возращает строку, если в ней находится искомое значение
        {
            int rows = DataBase.GetUpperBound(0) + 1;
            int cols = DataBase.Length / rows;
            string[] person = new string[rows];
            string res = "";
            string str = "";
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    str += DataBase[r, c] + " ";
                }
                person[r] = str + ";";
                str = "";
            }
            foreach(string p in person)
            {
                if(p.Contains(SearchingData))
                {
                    res += p;
                }

            }
            return res;
        }
    }
}
