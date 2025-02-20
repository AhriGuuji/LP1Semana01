using System;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            double xx = 1.23456;
            int ii = 19;
            string hello = "Hello LP1!";
            string aspas = "Existe algo \"Entre\" aspas";
            string heart = "Coração é assim ❤";
            Console.WriteLine($"{hello}\n{heart}\n{aspas}");
            string somaDeChars = "a" + 2;
            int x = 2;
            string somaDeVariaveis = "abc" + x;
            Console.WriteLine($"{somaDeChars}\n{somaDeVariaveis}");
            int y = 3;
            Console.WriteLine($"O valor de x e' {x}");
            Console.WriteLine($"{x} mais {y} e' igual a {x+y}");
            string xx1 = $"{xx:f2}";
            string xx2 = $"{xx:f1}";
            string ii1 = $"{ii:x}";
            string ii2 = $"{xx:c}";
            Console.WriteLine(xx1);
            Console.WriteLine(xx2);
            Console.WriteLine(ii1);
            Console.WriteLine(ii2);
        }
    }
}
