using System;
using System.Collections.Generic;
using System.Text;

namespace TesteTargetSistemas {
    class Faturamento {
        public void CalculateInvoicingPercentage() {

            // Cria um dicionário com o faturamento mensal de cada estado
            Dictionary<string, double> faturamentoDosEstados = new Dictionary<string, double> {
                {"SP", 67836.43},
                {"RJ", 36678.66},
                {"MG", 29229.88},
                {"ES", 27165.48},
                {"Outros", 19849.53},
            };

            // Calcula o faturamento total
            double faturamentoTotal = 0;
            foreach (double faturamentoEstadual in faturamentoDosEstados.Values) {
                faturamentoTotal += faturamentoEstadual;
            }

            Console.WriteLine(faturamentoTotal);
        }
    }
}
