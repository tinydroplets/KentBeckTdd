using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KentBeckTdd.UnitTests
{
    [TestClass]
    public class GeneralTests
    {
        [TestMethod]
        public void TestMultiplication()
        {
            var five = new Dollar(5);
            Assert.IsTrue(new Dollar(10).Equals(five.Times(2)));
            Assert.IsTrue(new Dollar(15).Equals(five.Times(3)));
        }

        [TestMethod]
        public void TestEquality()
        {
           Assert.IsTrue(new Dollar(5).Equals(new Dollar(5))); 
           //Assert.IsTrue(new Dollar(5).Equals(new Dollar(6)));
        }
    }
}
