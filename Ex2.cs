using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aresta;
            int area;

            Console.WriteLine("Informe o valor da aresta do quadrado: ");
            aresta = int.Parse(Console.ReadLine());

            area = aresta * aresta;

                Console.WriteLine("O valor da área do quadrado é {0} quando o valor da aresta for {1}", area, aresta);
        }
    }
}
