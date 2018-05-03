using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KentBeckTdd.UnitTests
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

        [TestMethod]
        public void TestEquality()
        {
           Assert.IsTrue(new Dollar(5).Equals(new Dollar(5))); 
           //Assert.IsTrue(new Dollar(5).Equals(new Dollar(6)));
        }
    }
}
