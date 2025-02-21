using System;
using System.Globalization;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Insira um número inteiro:");
            string pedirNumero = Console.ReadLine();
            int number = int.Parse(pedirNumero);

            Console.WriteLine("Insira um número real:");
            string pedirDecimal = Console.ReadLine();
            float aPartOfSomething = float.Parse(pedirDecimal);
            float sum =number+aPartOfSomething;
            Console.WriteLine($"A soma dos dois números é {sum}");
        }
    }
}
