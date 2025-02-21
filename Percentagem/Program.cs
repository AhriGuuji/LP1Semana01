using System;
using System.Globalization;

namespace Percentagem
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Insere 4 números reais entre 0 e 1:");
            //Inputs
            string number_1 = Console.ReadLine();
            string number_2 = Console.ReadLine();
            string number_3 = Console.ReadLine();
            string number_4 = Console.ReadLine();
            //Passar de String para Floats
            float number_to_float_1 = float.Parse(number_1);
            float number_to_float_2 = float.Parse(number_2);
            float number_to_float_3 = float.Parse(number_3);
            float number_to_float_4 = float.Parse(number_4);
            //Transformar os números reais em percentagens
            string rate_1 = $"{number_to_float_1:p}";
            string rate_2 = $"{number_to_float_2:p}";
            string rate_3 = $"{number_to_float_3:p}";
            string rate_4 = $"{number_to_float_4:p}";
            //Apresentar as respostas finais
            Console.WriteLine($"{rate_1}\n{rate_2}\n{rate_3}\n{rate_4}");
        }
    }
}
