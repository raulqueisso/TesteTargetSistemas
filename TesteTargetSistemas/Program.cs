using System;

namespace TesteTargetSistemas {
    class Program {
        static void Main(string[] args) {
            Fibonacci fibonacci = new Fibonacci();
            fibonacci.IsNumberOnFibonacciSequence(34);
        }

        static void RunSoma() {
            Soma soma = new Soma();

            soma.PrintSomaResult();
        }
    }
}
