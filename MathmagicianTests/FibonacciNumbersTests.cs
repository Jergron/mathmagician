using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathmagician;

namespace MathmagicianTests
{
    [TestClass]
    public class FibonacciNumbersTests
    {
        [TestMethod]
        public void FibonacciEnsureICanCreateClassInstance()
        {
            FibonacciNumbers fib = new FibonacciNumbers();
            Assert.IsNotNull(fib);
        }

        [TestMethod]
        public void FibonacciShouldPrintFirstNumber()
        {
            FibonacciNumbers fib = new FibonacciNumbers();
            int expected = 1;
            int actual = fib.GetFirst();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FibonacciShouldPrintNextNumber()
        {
            FibonacciNumbers fib = new FibonacciNumbers();
            int input = 1;
            int expected = 1;
            int actual = fib.GetNext(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FibonacciShouldPrintAVariableSequenceOfNumbers()
        {
            FibonacciNumbers fib = new FibonacciNumbers();
            int input = 8;
            int[] expected = new int[] { 1, 1, 2, 3, 5, 8, 13, 21 }; 
            int[] actual = fib.GetSequence(input);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FibonacciPrintSequencenumbers()
        {
            FibonacciNumbers fib = new FibonacciNumbers();
            int length = 7;
            string expected = "1 1 2 3 5 8 13";
            string actual = fib.ToString(fib.GetSequence(length));
            Assert.AreEqual(expected, actual);
        }

    }
}
