using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double cotacao;
            double dolar;
            double reais;

            Console.Write("Informe a atual cotação do dólar em reais(R$): ");
            cotacao = double.Parse(Console.ReadLine());

            Console.Write("Informe o valor em dólar a ser convertido: ");
            dolar = double.Parse(Console.ReadLine());

            reais = cotacao * dolar;

            Console.Write("O valor em reais(R$) é R${0} quando a cotação do dólar for R${1} e a quantidade a se converter for ${2} dólar(es).", reais, cotacao, dolar);
        }
    }
}
