using System;

namespace TesteTargetSistemas {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Problema 1:");
            RunSoma();
            Console.ReadLine();

            Console.WriteLine("Problema 2:");
            RunFibonacci();
            Console.ReadLine();

            Console.WriteLine("Não recebi por e-mail os arquivos do problema 3.");
            Console.ReadLine();

            Console.WriteLine("Problema 4:");
            RunFaturamento();
            Console.ReadLine();

            Console.WriteLine("Problema 5:");
            RunInverterString();
            Console.ReadLine();
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
