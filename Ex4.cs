using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double baze;
            double lado;
            double area;

            Console.Write("informe o valor da base do triângulo: ");
            baze = Double.Parse(Console.ReadLine());

            Console.WriteLine("Infrome o valor do lado do triângulo: ");
            lado = Double.Parse(Console.ReadLine());

            area = baze * lado / 2;

            Console.WriteLine("A área do tri^sngulo sera {0} quando o valor da base for {1} e a altura {2}.", area, baze, lado);


        }
    }
}
