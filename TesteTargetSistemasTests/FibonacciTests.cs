using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesteTargetSistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace TesteTargetSistemas.Tests {
    [TestClass()]
    public class FibonacciTests {
        [TestMethod("Testa se o número pertence à sequência de Fibonacci")]
        public void IsNumberOnFibonacciSequenceTest() {
            Fibonacci fibonacci = new Fibonacci();

            Assert.IsTrue(fibonacci.IsNumberOnFibonacciSequence(21));
        }

        [TestMethod("Testa se o número não pertence à sequência de Fibonacci")]
        public void IsNumberNotOnFibonacciSequenceTest() {
            Fibonacci fibonacci = new Fibonacci();

            Assert.IsFalse(fibonacci.IsNumberOnFibonacciSequence(17));
        }

        [TestMethod("Testa se a sequência de Fibonacci está certa")]
        public void CreateFibonacciSequenceTest() {
            Fibonacci fibonacci = new Fibonacci();

            var sequenceExpected = new List<int>() {
                0, 1, 1, 2, 3, 5, 8, 13, 21, 34
            };

            CollectionAssert.AreEqual(sequenceExpected, fibonacci.CreateFibonacciSequence(34));
        }
    }
}