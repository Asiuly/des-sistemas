using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIFELSE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Entrada de dados do usuário
            Console.WriteLine("Informações sobre a compra (Compre mais de 100 unidades e ganhe desconto!)");
            Console.Write("\nDigite a quantidade de produto comprada: ");
            double quantidade = double.Parse(Console.ReadLine());

            Console.Write("Insira o valor unitário do produto: R$");
            double valor = double.Parse(Console.ReadLine());

            //processamento de variaveis
            double ValorBruto = valor * quantidade;

            //Atribuição de condições à variavel
            if (quantidade >= 100)
            {
                Console.WriteLine("\nParabéns, você atingiu a quantidade necessária para descontos");
                Console.Write("Informe a % de desconto adquirida: ");
                double porcentagem = double.Parse(Console.ReadLine());

                double ValorLiquido = ValorBruto - (ValorBruto * porcentagem / 100);
                Console.Write("\nO valor total de sua compra foi de: {0}", ValorLiquido.ToString("C"));
            }
            else
            {
                Console.WriteLine("\nInfelizmente, você não atingiu a quantidade necessária para adquirir desconto");
                Console.Write("O valor final de sua compra é de: {0}", ValorBruto.ToString("C"));
            }

            //Execução do Código
            Console.ReadKey();



        }
    }
}
