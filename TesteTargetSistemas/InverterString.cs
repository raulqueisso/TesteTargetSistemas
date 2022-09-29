using System;
using System.Collections.Generic;
using System.Text;

namespace TesteTargetSistemas {
    public class InverterString {
        public string Invert(string text) {
            string inverted = "";

            for (int i = 0; i < text.Length; i++) {
                inverted += text[text.Length - 1 - i];
            }

            Console.WriteLine(inverted);
            return inverted;
        }
    }
}
