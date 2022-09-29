using System;

namespace TesteTargetSistemas {
    class Program {
        static void Main(string[] args) {
            RunSoma();
        }

        static void RunSoma() {
            Soma soma = new Soma();

            soma.PrintSomaResult();
        }
    }
}
