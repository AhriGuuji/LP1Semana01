using System;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string pedirNumero = Console.ReadLine();
            int number = int.Parse(pedirNumero);
            Console.WriteLine(number);
        }
    }
}
