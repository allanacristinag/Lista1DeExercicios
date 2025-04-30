using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int celsius;
            double fahrenheit;

            Console.Write("Informe o valor de graus celsius: ");
            celsius = int.Parse(Console.ReadLine());

            fahrenheit = celsius * 1.8 + 32;

            Console.Write("A temperatura em fahrenheit é {0} quando em celsius for {1}", fahrenheit, celsius);


        }
    }
}
