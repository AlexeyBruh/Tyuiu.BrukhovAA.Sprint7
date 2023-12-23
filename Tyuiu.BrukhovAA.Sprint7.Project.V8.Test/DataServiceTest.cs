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
            string[,] waitArr = new string[4, 7] { { "1-ТН", "Иванов", "Андрей", "Петрович", "20.02.1993", "7", "50400" }, 
                                                   { "2-ТН", "Петров", "Василий", "Ибрагимович", "14.06.1982", "12", "65300" },
                                                   { "3-ТН", "Сувовор", "Павел", "Максимович", "08.08.1995", "6", "44320" }, 
                                                   { "4-ТН", "Павлов", "Иван", "Евгеньевич", "26.03.2000", "3", "40080" } };

            string[,] resArr = ds.LoadFromFileData(filePath);
            CollectionAssert.AreEqual(waitArr, resArr);
        }
        [TestMethod]
        public void ValidSearchForString()
        {

            string[,] DataBase = ds.LoadFromFileData(filePath);
            string search = "2-ТН";
            string res = ds.SearchForString(DataBase, search);
            string wait = "2-ТН Петров Василий Ибрагимович 14.06.1982 12 65300 ;";
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidAmountOfData()
        {
            int wait = 4;
            int res = ds.amountOfData(ds.LoadFromFileData(filePath));
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidAverageNumber()
        {
            string[,] DataBase = ds.LoadFromFileData(filePath);
            double wait = 7;
            bool switcher = false; 
            double res = ds.AverageNumberPaymentOrAgeOfWork(DataBase, switcher);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidSumPayment()
        {
            double res = ds.SumOfPayment(ds.LoadFromFileData(filePath));
            double wait = 200100;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidMaxPayment()
        {
            bool switcher = false;
            double res = ds.MaxPaymentOrAge(ds.LoadFromFileData(filePath), switcher);
            double wait = 12;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidMinPayment()
        {
            bool switcher = false;
            double res = ds.MinPaymentOrAge(ds.LoadFromFileData(filePath), switcher);
            double wait = 3;
            Assert.AreEqual(wait, res);
        }

    }
}
