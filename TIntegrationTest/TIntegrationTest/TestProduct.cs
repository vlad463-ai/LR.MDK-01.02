using System;
using System.Collections.Generic;
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
            Assert.AreEqual(expected[0].Name, actual[0].Name);
            Assert.AreEqual(expected[0].Price, actual[0].Price);
            Assert.AreEqual(expected[0].Count, actual[0].Count);


        }
    }
}
