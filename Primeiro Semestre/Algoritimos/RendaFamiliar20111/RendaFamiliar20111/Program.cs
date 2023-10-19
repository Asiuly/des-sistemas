using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RendaFamiliar20111
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instruções ao usuário
            Console.WriteLine("Calculo de renda familiar");

            //entrada de dados
            Console.Write("\nInforme a Renda Familiar: R$");
            double renda = double.Parse(Console.ReadLine());

            Console.Write("Informe o valor gasto com alimentação: R$");
            double despesas = double.Parse(Console.ReadLine());

            Console.Write("Informe o valor gasto com farmácia: R$");
            despesas += double.Parse(Console.ReadLine());

            Console.Write("Informe o valor gasto com vestuário: R$");
            despesas += double.Parse(Console.ReadLine());

            Console.Write("Informe o valor gasto com outros gastos: R$");
            despesas += double.Parse(Console.ReadLine());

            //processamento de variaveis
            double resto = renda - despesas;

            //Atribuição de condições

            if (resto >= 0)
                Console.WriteLine("Que ótimo, a renda desse mês foi suficiente e ainda te sobraram {0}", resto.ToString("C"));

            else
                Console.WriteLine("Ah, que pena, a sua renda não foi suficiente, faltaram R${0}", resto*-1);

            //Execução do Código 
            Console.ReadKey();

        }
    }
}
