using System;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
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
        }
    }
}
