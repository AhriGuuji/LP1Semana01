using System;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insira um número inteiro:");
            string pedirNumero = Console.ReadLine();
            int number = int.Parse(pedirNumero);
            Console.WriteLine(number);
            Console.WriteLine("Insira um número real:");
            string pedirDecimal = Console.ReadLine();
            float aPartOfSomething = float.Parse(pedirDecimal);
            Console.WriteLine(aPartOfSomething);
            Console.WriteLine($"A soma dos dois números é {number+aPartOfSomething}");
        }
    }
}
