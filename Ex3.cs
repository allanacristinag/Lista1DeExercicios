using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            double diagonal1;
            double area;

            Console.Write("Informe o valor da diagonal do quadrado: ");
            diagonal1 = double.Parse(Console.ReadLine());

            area = diagonal1 * diagonal1 / 2;

            Console.WriteLine("A área do quadrado a partir do valor da sua diagonal sera {0} quando sua diagonal for {1}", area, diagonal1);

        }
    }
}
