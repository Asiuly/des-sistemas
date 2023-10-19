using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaração variavel para laço de repetição
            int cont = 1;

            //Entrada de dados do usuário
            Console.Write("Informe o valor da anuidade: R$");
            double anuidade = double.Parse(Console.ReadLine());

            Console.Write("Informe o valor do matricula: R$");
            double matricula = double.Parse(Console.ReadLine());

            Console.Write("Informe o valor do material: R$");
            double material = double.Parse(Console.ReadLine());

            //Laço de Repetição
            while (cont <= 12)
            {
                double mensalidade = anuidade / 12;

                if (cont == 1)
                    mensalidade += matricula + material;

                Console.WriteLine("Mensalidade {0} valor: {1}", cont, mensalidade.ToString("C"));
                cont++;
            }

            //Execução do Código
            Console.ReadKey();
        }
    }
}
