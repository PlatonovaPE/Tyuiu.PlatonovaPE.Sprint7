using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PlatonovaPE.Sprint7.V11.Lib;

namespace Project.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\parse\source\repos\Tyuiu.PlatonovaPE.Sprint7\Tyuiu.PlatonovaPE.Sprint7.V11.Lib\bin\Debug\net8.0\Сезонность сотрудников.txt";

            CollectionAssert.AreEqual(new double[] { 4, 12, 14, 15, 9, 7, 5, 4, 7, 9, 10, 1 }, ds.LoadFromDataFile(path));
        }
    }
}