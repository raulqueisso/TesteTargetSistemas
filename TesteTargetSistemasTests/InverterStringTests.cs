using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesteTargetSistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace TesteTargetSistemas.Tests {
    [TestClass()]
    public class InverterStringTests {
        [TestMethod("Teste se o texto é invertido corretamente")]
        public void InvertTest() {
            InverterString inverterString = new InverterString();

            Assert.AreEqual("dlrow ,olleh", inverterString.Invert("hello, world"));
        }
    }
}