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
            string[,] waitArr = new string[5, 7] { { "1-ТН", "Иванов", "Андрей", "Петрович", "20.02.1993", "7", "50400" }, 
                                                   { "2-ТН", "Петров", "Василий", "Ибрагимович", "14.06.1982", "12", "65300" },
                                                   { "3-ТН", "Сувовор", "Павел", "Максимович", "08.08.1995", "6", "44320" }, 
                                                   { "4-ТН", "Павлов", "Иван", "Евгеньевич", "26.03.2000", "3", "40080" }, 
                                                   {"5-ТН", "Кабачков", "Максим", "Кириллович", "30.05.1992", "8", "51380"} };

            string[,] resArr = ds.LoadFromFileData(filePath);
            CollectionAssert.AreEqual(waitArr, resArr);
        }

        [TestMethod]
        public void ValidAmountOfData()
        {
            int wait = 5;
            int res = ds.amountOfData(ds.LoadFromFileData(filePath));
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidAverageNumber()
        {
            string[,] DataBase = ds.LoadFromFileData(filePath);
            double wait = 7.2;
            int rows = 5;
            bool switcher = false; 
            double res = ds.AverageNumberPaymentOrAgeOfWork(DataBase, switcher, rows);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidSumPayment()
        {
            int rows = 5;
            double res = ds.SumOfPayment(ds.LoadFromFileData(filePath), rows);
            double wait = 251480;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidMaxPayment()
        {
            int rows = 5;
            bool switcher = false;
            double res = ds.MaxPaymentOrAge(ds.LoadFromFileData(filePath), switcher, rows);
            double wait = 12;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidMinPayment()
        {
            int rows = 5;
            bool switcher = false;
            double res = ds.MinPaymentOrAge(ds.LoadFromFileData(filePath), switcher, rows);
            double wait = 3;
            Assert.AreEqual(wait, res);
        }

    }
}
