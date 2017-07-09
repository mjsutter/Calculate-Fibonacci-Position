using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculateFibonacciValuePosition;

namespace CalculateFibonacciValuePostionTests
{
    [TestClass]
    public class FibonacciTests
    {
        [TestCategory("UnitTest")]
        [TestMethod]
        public void CalculateFibonacci_Postion_10_Should_Return_55()
        {
            //assemble
            int postion = 10;
            int expectedValue = 55;
            Fibonacci fibonacci = new Fibonacci();

            //act
            int actualValue = fibonacci.CalculateFibonacci(postion);

            //asert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void CalculateFibonacci_Postion_40_Should_Return_102334155()
        {
            //assemble
            int postion = 40;
            int expectedValue = 102334155;
            Fibonacci fibonacci = new Fibonacci();

            //act
            int actualValue = fibonacci.CalculateFibonacci(postion);

            //assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
