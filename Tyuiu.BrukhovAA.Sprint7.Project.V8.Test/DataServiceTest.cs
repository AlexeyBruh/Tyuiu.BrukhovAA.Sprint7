using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BrukhovAA.Sprint7.Project.V8.Lib;
using System.IO;

namespace Tyuiu.BrukhovAA.Sprint7.Project.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromFileData()
        {
            DataService ds = new DataService();
            string filePath = @"C:\Users\bruho\OneDrive\Рабочий стол\Программирование шаблоны\Матрица с водителями.csv";

            string[,] waitArr = new string[4, 7] { { "1", "Иванов", "Андрей", "Петрович", "20.02.1993", "7", "50400" }, 
                                                   { "2", "Петров", "Василий", "Ибрагимович", "14.06.1982", "12", "65300" },
                                                   { "3", "Сувовор", "Павел", "Максимович", "08.08.1995", "6", "44320" }, 
                                                   { "4", "Павлов", "Иван", "Евгеньевич", "26.03.2000", "3", "40080" } };

            string[,] resArr = ds.LoadFromFileData(filePath);
            CollectionAssert.AreEqual(waitArr, resArr);
        }
    }
}
