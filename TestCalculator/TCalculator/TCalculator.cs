using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TCalculator
{
    [TestClass]
    public class TCalculator
    {
        Calculatorr calculator = new Calculatorr();

        [TestMethod]
        public void TestAddition()
        {
            int x = 6;
            int y = 5;

            double expected = 11;
            double actual = calculator.Addition(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSubstraction()
        {
            int x = 6;
            int y = 5;

            double expected = 1;
            double actual = calculator.Subtraction(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultiplication()
        {
            int x = 6;
            int y = 5;

            double expected = 30;
            double actual = calculator.Multiplication(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDivide()
        {
            int x = 10;
            int y = 5;

            double expected = 2;
            double actual = calculator.Divide(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDivideWithZero()
        {
            int x = 10;
            int y = 0;

            double expected = 0;
            double actual = calculator.Divide(x, y);
            Assert.AreEqual(expected, actual);
        }
    }
}
