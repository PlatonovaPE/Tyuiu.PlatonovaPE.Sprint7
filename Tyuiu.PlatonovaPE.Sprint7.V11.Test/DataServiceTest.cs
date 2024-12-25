using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PlatonovaPE.Sprint7.V11.Lib;

namespace Tyuiu.PlatonovaPE.Sprint7.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        
        [TestMethod]
        public void CheckRowsAddedInTable()
        {
            string[,] matrixTable = { { "1", "2", "3", }, { "4", "5", "6" } };
            string[,] matrixRes = ds.RowsAddedInTable(matrixTable, 5);
            string[,] matrixWait = { { "1", "2", "3", }, { "4", "5", "6" }, { null, null, null }, { null, null, null }, { null, null, null } };
            CollectionAssert.AreEquivalent(matrixRes, matrixWait);
        }
        [TestMethod]
        public void CheckSaveFileToPath()
        {
            string[,] matrixTable = { { "1", "2", "3", }, { "4", "5", "6" } };
            string path = Path.Combine(Path.GetTempPath(), "CheckTable.csv");
            ds.SaveFileToPath(path, matrixTable);
            Assert.IsTrue(File.Exists(path));
        }
    }
}