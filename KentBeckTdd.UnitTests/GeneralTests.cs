using System.Runtime.InteropServices;
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
            Assert.IsTrue(Money.dollar(5).Equals(Money.dollar(5)));
            Assert.IsFalse(Money.dollar(5).Equals(Money.dollar(6)));
            Assert.IsFalse(Money.franc(5).Equals(Money.dollar(5)));
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

        [TestMethod]
        public void TestSimpleAddition()
        {
            var five = Money.dollar(5);
            var sum = five.plus(five);
            var bank = new Bank();
            var reduced = bank.Reduce(sum, "USD");
            Assert.IsTrue(Money.dollar(10).Equals(reduced));
        }

        [TestMethod]
        public void TestPlusReturnsSum()
        {
            var five = Money.dollar(5);
            var result = five.plus(five);
            var sum = (Sum) result;
            Assert.AreEqual(five, sum.augend);
            Assert.AreEqual(five, sum.addend);
        }

        [TestMethod]
        public void TestReduceSum()
        {
            var sum = new Sum(Money.dollar(3), Money.dollar(4));
            var bank = new Bank();
            var result = bank.Reduce(sum, "USD");
            Assert.IsTrue(Money.dollar(7).Equals(result));
        }

        [TestMethod]
        public void TestReduceMoney()
        {
            var bank = new Bank();
            var result = bank.Reduce(Money.dollar(1), "USD");
            Assert.IsTrue(Money.dollar(1).Equals(result));
        }
    }
}
