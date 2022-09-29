using System;
using System.Collections.Generic;
using System.Text;

namespace TesteTargetSistemas {
    public class Soma {
        public int PrintSomaResult() {
            int indice = 13;
            int soma = 0;
            int k = 0;

            while (k < indice) {
                k++;
                soma += k;
            }

            Console.WriteLine(soma);
            return soma;
        }
    }
}
