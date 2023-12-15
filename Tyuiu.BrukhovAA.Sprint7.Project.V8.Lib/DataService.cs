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
            foreach (string p in person)
            {
                if (p.Contains(SearchingData))
                {
                    res += p;
                }

            }
            return res;
        }

        public int amountOfData(string[,] DataBase)// метод, который возращает количество строк в БД
        {
            int count = DataBase.GetUpperBound(0) + 1;
            return count;
        }
        public double AverageNumberPaymentOrAgeOfWork(string[,] DataBase, bool switcher)// метод, который вычисляет среднее число зарплаты сотрудников или стаж по выбору пользователя
        {
            int rows = DataBase.GetUpperBound(0) + 1;
            double sumPayment = 0;
            if(switcher == true)
            {
                for (int r = 0; r < rows; r++)
                {
                    sumPayment += Convert.ToInt32(DataBase[r, 6]);
                }
                double res = sumPayment / rows;
                return Math.Round(res, 3);
            }
            else
            {
                for (int r = 0; r < rows; r++)
                {
                    sumPayment += Convert.ToInt32(DataBase[r, 5]);
                }
                double res = sumPayment / rows;
                return Math.Round(res, 3);
            }

        }
        public double SumOfPayment(string[,] DataBase)// метод, который вычисляет сумму зарплат сотрудников
        {
            int rows = DataBase.GetUpperBound(0) + 1;
            double sumPayment = 0;
            for (int r = 0; r < rows; r++)
            {
                sumPayment += Convert.ToInt32(DataBase[r, 6]);
            }
            return sumPayment;
        }
        public double MaxPaymentOrAge(string[,] DataBase, bool switcher)//метод, который находит максимальную зарплату или максимальный стаж по выбору пользователя
        {
            int rows = DataBase.GetUpperBound(0) + 1;
            double sumPayment = 0;
            if (switcher == true)
            {
                for (int r = 0; r < rows; r++)
                {
                    if (Convert.ToInt32(DataBase[r, 6]) > sumPayment)
                    {
                        sumPayment = Convert.ToInt32(DataBase[r, 6]);
                    }

                }
            return sumPayment;
            }
            else
            {
                for (int r = 0; r < rows; r++)
                {
                    if (Convert.ToInt32(DataBase[r, 5]) > sumPayment)
                    {
                        sumPayment = Convert.ToInt32(DataBase[r, 5]);
                    }

                }
                return sumPayment;
            }

        }
        public double MinPaymentOrAge(string[,] DataBase, bool switcher)//метод, который находит минимальную зарплату или минимальный стаж по выбору пользователя
        {
            int rows = DataBase.GetUpperBound(0) + 1;
            if (switcher == true)
            {
                double sumPayment = Convert.ToInt32(DataBase[1, 6]);
                for (int r = 0; r < rows; r++)
                {
                    if (Convert.ToInt32(DataBase[r, 6]) < sumPayment)
                    {
                        sumPayment = Convert.ToInt32(DataBase[r, 6]);
                    }
                }
                return sumPayment;
            }
            else
            {
                double sumPayment = Convert.ToInt32(DataBase[1, 5]);
                for (int r = 0; r < rows; r++)
                {
                    if (Convert.ToInt32(DataBase[r, 5]) < sumPayment)
                    {
                        sumPayment = Convert.ToInt32(DataBase[r, 5]);
                    }
                }
                return sumPayment;
            }

        }
    }
}
