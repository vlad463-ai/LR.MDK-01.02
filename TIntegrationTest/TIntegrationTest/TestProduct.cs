using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestLib;

namespace TIntegrationTest
{
    [TestClass]
    public class TestProduct
    {
        
        [TestMethod]
        public void TestReadAllFromFile()
        {
            List<Product> actual = new List<Product>();
            SaleImporter saleImporter = new SaleImporter();
            actual = saleImporter.ReadAllFromFile();
            List<Product> expected = new List<Product>
            {
                  new Product{Name ="Винаград",Price = 1000,Count =  15 },
                  new Product{Name ="Слива", Price = 1500,Count =  3 },
                  new Product{Name ="Яблаки", Price = 500,Count =  26 },
                  new Product{Name ="Бабан", Price = 100,Count =  10 }
            };
            Assert.AreEqual(expected.Count, actual.Count);
            for(int i =0; i<expected.Count;i++)
            {
                Assert.AreEqual(expected[i].Name, actual[i].Name);
                Assert.AreEqual(expected[i].Price, actual[i].Price);
                Assert.AreEqual(expected[i].Count, actual[i].Count);
            }
            


        }
        [TestMethod]
        public void TestSellsAnalyzes()
        {
            SellsAnalyzes.countProducts();
        }
    }
}
