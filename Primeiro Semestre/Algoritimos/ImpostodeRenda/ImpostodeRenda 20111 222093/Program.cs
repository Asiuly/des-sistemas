using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostodeRenda_20111_222093
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // entrada de dados
            Console.Write("Digite seu salario: R$");
            double salario = double.Parse(Console.ReadLine());

            //Atribuição de condições
            if (salario <= 2000)
            {
                Console.Write("O imposto de renda será de 7,5% do seu salário, o valor é de: R$ " + salario * 7.5 / 100);
            }

            else if (salario > 4000)
            {
                Console.Write("O imposto de renda será de 15% do seu salário, o valor é de: R$" + salario * 15 / 100);
            }

            else
            {
                Console.Write("O imposto de renda será de 12% do seu salário, o valor é de: R$" + salario * 12 / 100);
            }

            //Execução do código
            Console.ReadKey();
        }
    }
}
