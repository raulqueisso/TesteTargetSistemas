using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesteTargetSistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace TesteTargetSistemas.Tests {
    [TestClass()]
    public class SomaTests {
        [TestMethod("Testa o resultado da soma")]
        public void PrintSomaResultTest() {
            Soma soma = new Soma();

            Assert.AreEqual(91, soma.PrintSomaResult());
        }
    }
}