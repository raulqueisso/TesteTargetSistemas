using System;

namespace TesteTargetSistemas {
    class Program {
        static void Main(string[] args) {
            RunInverterString();
        }

        static void RunSoma() {
            Soma soma = new Soma();
            soma.PrintSomaResult();
        }

        static void RunFibonacci() {

            // Recebe um número inteiro e testa se o número está na sequência de Fibonacci
            string input;
            int number;

            do {
                Console.WriteLine("Digite um número: ");
                input = Console.ReadLine();
            }
            while (!int.TryParse(input, out number));

            Fibonacci fibonacci = new Fibonacci();
            fibonacci.IsNumberOnFibonacciSequence(number);
        }

        static void RunFaturamento() {
            Faturamento faturamento = new Faturamento();
            faturamento.CalculaPercentualDeRepresentacao();
        }

        static void RunInverterString() {
            Console.WriteLine("Digite um texto: ");
            var input = Console.ReadLine();

            InverterString inverterString = new InverterString();
            inverterString.Invert(input);
        }
    }
}
