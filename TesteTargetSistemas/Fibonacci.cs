﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TesteTargetSistemas {
    public class Fibonacci {
        public bool IsNumberOnFibonacciSequence(int targetNumber) {
            
            // Cria a sequência de Fibonacci
            List<int> sequence = CreateFibonacciSequence(targetNumber);

            foreach(int number in sequence) {
                Console.WriteLine(number);
            }

            return false;
        }

        public List<int> CreateFibonacciSequence(int targetNumber) {

            // Inicia sequência com os valores iniciais de 0 e 1
            List<int> sequence = new List<int>();
            sequence.Add(0);
            sequence.Add(1);

            // Adciona na lista um número seguindo a sequência de Fibonacci enquanto o último número for menor que o valor procurado
            while(sequence[sequence.Count - 1] < targetNumber) {
                int newNumber = sequence[sequence.Count - 1] + sequence[sequence.Count - 2];
                sequence.Add(newNumber);
            }

            return sequence;
        }
    }
}
