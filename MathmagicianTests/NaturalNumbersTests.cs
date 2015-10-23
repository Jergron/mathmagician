using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//Add "using" the name of the project. The namespace for any project is the name of the project
using Mathmagician;

namespace MathmagicianTests
{
    [TestClass]
    public class NaturalNumbersTests
    {
        [TestMethod]
        // All your test methods need to be unique
        // Figure out how to name your tests in accordance to what you're wanting to achieve
        public void EnsureICanCreateClassInstance()
        {
          
            NaturalNumbers nats = new NaturalNumbers();
            //The assert class finds out what is true or false
            Assert.IsNotNull(nats); 
        }

        // type [testm tab tab] for a "test method" to appear:
        [TestMethod]
        public void ShouldPrintFirstNumber()
        {
            NaturalNumbers nats = new NaturalNumbers();
            int expected = 1;
            int actual = nats.GetFirst();
            //asserts can compare expected outputs vs actual outputs
            Assert.AreEqual(expected, actual);
        }

        /*
        This test is for educational purposes

        [TestMethod]
        [ExpectedException(typeof(AccessViolationException))]
        public void NooneCanAccessPrivateDataMember()
        {
            NaturalNumbers nats = new NaturalNumbers();
            //Whoops won't even compile ;)
            //nats.first;
        }
        */

        [TestMethod]
        public void ShouldPrintNextNumber()
        {
            NaturalNumbers nats = new NaturalNumbers();
            int input = 1;
            int expected = 2;
            int actual = nats.GetNext(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldPrintNextNumber3()
        {
            NaturalNumbers nats = new NaturalNumbers();
            int input = 3;
            int expected = 4;
            int actual = nats.GetNext(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldPrintSequenceOfNumbers()
        {
            NaturalNumbers nats = new NaturalNumbers();
            int[] expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] actual = nats.GetSequence();
            //Collection Assert compares collections 
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldPrintAVariableSequenceOfNumbers()
        {
            NaturalNumbers nats = new NaturalNumbers();
            int input = 8;
            int[] expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] actual = nats.GetSequence(input);
            //Collection Assert compares collections 
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldProvideSameSequences()
        {
            NaturalNumbers nats = new NaturalNumbers();
            int input = 10;
            int[] sequencewithlength = nats.GetSequence(input);
            int[] sequencenolength = nats.GetSequence();
            CollectionAssert.AreEqual(sequencenolength, sequencewithlength);
        }

        [TestMethod]
        public void PrintSequencenumbers()
        {
            NaturalNumbers nats = new NaturalNumbers();
            int length = 7;
            string expected = "1 2 3 4 5 6 7";
            string actual = nats.ToString(nats.GetSequence(length));
            Assert.AreEqual(expected, actual);
        }
    }
}
