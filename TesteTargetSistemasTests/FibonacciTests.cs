using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesteTargetSistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace TesteTargetSistemas.Tests {
    [TestClass()]
    public class FibonacciTests {
        [TestMethod()]
        public void IsNumberOnFibonacciSequenceTest() {
            Assert.Fail();
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