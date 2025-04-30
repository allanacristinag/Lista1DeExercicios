using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor1;
            int valor2;
            int valor3;
            int valor4;
            double soma;
            double media;

            Console.Write("Informe o primeiro valor: ");
            valor1 = int.Parse(Console.ReadLine());

            Console.Write("Informe o segundo valor: ");
            valor2 = int.Parse(Console.ReadLine());

            Console.Write("Informe o terceiro valor: ");
            valor3 = int.Parse(Console.ReadLine());

            Console.Write("Informe o quarto valor: ");
            valor4 = int.Parse(Console.ReadLine());

            soma = valor1 + valor2 + valor3 + valor4;
            media = soma / 4;

            Console.WriteLine($"A média aritmética do valor {valor1}, {valor2}, {valor3}, {valor4}, será {media}.");

        }
    }
}
