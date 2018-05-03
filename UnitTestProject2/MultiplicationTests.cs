using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KentBeckTdd;

namespace UnitTestProject2
{
    [TestClass]
    public class MultiplicationTests
    {
        [TestMethod]
        public void TestMultiplication()
        {
            var five = new Dollar(5);
            var product = five.Times(2);
            Assert.AreEqual(10, product.amount);
            product = five.Times(3);
            Assert.AreEqual(15, product.amount);
        }
    }
}
