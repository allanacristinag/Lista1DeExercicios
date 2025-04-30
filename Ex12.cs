using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double produto1;
            double produto2;
            double produto3;
            double produto4;
            double produto5;
            double resultado;
            double pagamento;
            double troco;

            Console.Write("Informe o valor do produto: ");
            produto1 = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor do produto: ");
            produto2 = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor do produto: ");
            produto3 = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor do produto: ");
            produto4 = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor do produto: ");
            produto5 = double.Parse(Console.ReadLine());

            resultado = produto1 + produto2 + produto3 + produto4 + produto5;

            Console.Write("Valor dado para pagamento: ");
            pagamento = double.Parse(Console.ReadLine());

            troco = resultado - pagamento;

            Console.Write("O valor de troco para R${0} é R${1}", resultado, troco);
            troco = double.Parse(Console.ReadLine());

        }
    }
}
