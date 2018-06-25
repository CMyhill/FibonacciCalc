using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FibonacciLib.Test
{
    [TestClass]
    public class FibonacciCalcTests
    {
        [TestMethod]
        public void Get_WhenGivenLength_WilReturnCorrectSequence()
        {
            var length = 5;

            var result = FibonacciCalc.Get(length);

            Assert.AreEqual(result.Length, length);
            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(1, result[1]);
            Assert.AreEqual(2, result[2]);
            Assert.AreEqual(3, result[3]);
            Assert.AreEqual(5, result[4]);
        }
    }
}
