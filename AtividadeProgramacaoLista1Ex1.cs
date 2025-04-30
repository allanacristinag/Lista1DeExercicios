using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeAtividades1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int baze;
            int altura;
            int area;

            Console.Write("Informe o valor da base do retângulo: ");
            baze = int.Parse(Console.ReadLine());

            Console.Write("informe o valor da altura do retângulo: ");
            altura = int.Parse(Console.ReadLine());

            area = baze * altura;

            Console.WriteLine("A área do retângulo sera {0}, quando a base for {1}, e a altura for {2}", area, baze, altura);

        }
    }
}
