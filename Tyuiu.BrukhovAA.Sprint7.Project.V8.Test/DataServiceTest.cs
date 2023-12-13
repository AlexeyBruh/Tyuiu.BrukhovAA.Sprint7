using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BrukhovAA.Sprint7.Project.V8.Lib;
using System.IO;

namespace Tyuiu.BrukhovAA.Sprint7.Project.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        string filePath = @"C:\Users\bruho\OneDrive\Рабочий стол\Программирование шаблоны\Матрица с водителями.csv";
        [TestMethod]
        public void ValidLoadFromFileData()
        {
            string[,] waitArr = new string[4, 7] { { "ТН-1", "Иванов", "Андрей", "Петрович", "20.02.1993", "7", "50400" }, 
                                                   { "ТН-2", "Петров", "Василий", "Ибрагимович", "14.06.1982", "12", "65300" },
                                                   { "ТН-3", "Сувовор", "Павел", "Максимович", "08.08.1995", "6", "44320" }, 
                                                   { "ТН-4", "Павлов", "Иван", "Евгеньевич", "26.03.2000", "3", "40080" } };

            string[,] resArr = ds.LoadFromFileData(filePath);
            CollectionAssert.AreEqual(waitArr, resArr);
        }
        [TestMethod]
        public void ValidSearchForString()
        {

            string[,] DataBase = ds.LoadFromFileData(filePath);
            string search = "ТН-2";
            string res = ds.SearchForString(DataBase, search);
            string wait = "ТН-2 Петров Василий Ибрагимович 14.06.1982 12 65300 ;";
            Assert.AreEqual(wait, res);
        }
    }
}
