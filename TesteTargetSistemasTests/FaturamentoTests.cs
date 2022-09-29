using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesteTargetSistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace TesteTargetSistemas.Tests {
    [TestClass()]
    public class FaturamentoTests {
        [TestMethod("Testa se o percentual de cada estado esá correto")]
        public void CalculaPercentualDeRepresentacaoTest() {
            Dictionary<string, double> expected = new Dictionary<string, double> {
                {"SP", 37.53},
                {"RJ", 20.29},
                {"MG", 16.17},
                {"ES", 15.03},
                {"Outros", 10.98},
            };

            Faturamento faturamento = new Faturamento();

            CollectionAssert.AreEqual(expected, faturamento.CalculaPercentualDeRepresentacao());
        }
    }
}