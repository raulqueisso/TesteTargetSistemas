using System;
using System.Collections.Generic;
using System.Text;

namespace TesteTargetSistemas {
    public class Faturamento {
        public Dictionary<string, double> CalculaPercentualDeRepresentacao() {

            // Cria um dicionário com o faturamento mensal de cada estado
            Dictionary<string, double> faturamentoDosEstados = new Dictionary<string, double> {
                {"SP", 67836.43},
                {"RJ", 36678.66},
                {"MG", 29229.88},
                {"ES", 27165.48},
                {"Outros", 19849.53},
            };

            // Calcula o faturamento total
            var faturamentoTotal = 0.0;
            foreach (double valorFaturamentoEstadual in faturamentoDosEstados.Values) {
                faturamentoTotal += valorFaturamentoEstadual;
            }

            // Cria um dicionário vazio para os percentuais
            Dictionary<string, double> percentuaisDeFaturamento = new Dictionary<string, double>();

            // Adciona o percentual de cada estado ao dicionário e imprime o resultado
            foreach (KeyValuePair<string, double> faturamentoEstadual in faturamentoDosEstados) {
                var percentual = Math.Round(faturamentoEstadual.Value * 100 / faturamentoTotal, 2);
                percentuaisDeFaturamento.Add(faturamentoEstadual.Key, percentual);

                Console.WriteLine($"O percentual de faturamento de {faturamentoEstadual.Key} foi de {percentual}%.");
            }

            // Retorna o dicionário de percentuais para realizar testes
            return percentuaisDeFaturamento;
        }
    }
}
