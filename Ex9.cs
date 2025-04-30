using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double diametro;
            double raio;
            double area;

            Console.Write("Informe o valor do diâmetro do círculo: ");
            diametro = double.Parse(Console.ReadLine());

            raio = diametro / 2;
            area = 3.14 * raio * raio;

            Console.Write("A área do círculo é {0}, quando seu diâmetro for {1}", area, diametro);


        }
    }
}
