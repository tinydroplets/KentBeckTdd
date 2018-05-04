using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KentBeckTdd.UnitTests
{
    [TestClass]
    public class GeneralTests
    {
        [TestMethod]
        public void TestMultiplication()
        {
            var five = Money.dollar(5); 
            Assert.IsTrue(Money.dollar(10).Equals(five.Times(2)));
            Assert.IsTrue(Money.dollar(15).Equals(five.Times(3)));
        }

        [TestMethod]
        public void TestEquality()
        {
            //Assert.IsTrue(Money.dollar(5).Equals(new Dollar(5)));
            //Assert.IsFalse(Money.dollar(5).Equals(new Dollar(6)));
            //Assert.IsTrue(Money.franc(5).Equals(Money.franc(5)));
            //Assert.IsFalse(Money.franc(5).Equals(Money.franc(6)));
            //Assert.IsFalse(Money.franc(5).Equals(new Dollar(5)));
        }

        [TestMethod]
        public void TestFrancMultiplication()
        {
            var five = Money.franc(5);
            Assert.IsTrue(Money.franc(10).Equals(five.Times(2)));
            Assert.IsTrue(Money.franc(15).Equals(five.Times(3)));
        }

        [TestMethod]
        public void TestCurrency()
        {
            Assert.AreEqual("USD", Money.dollar(1).currency());
            Assert.AreEqual("CHF", Money.franc(1).currency());
        }
    }
}
