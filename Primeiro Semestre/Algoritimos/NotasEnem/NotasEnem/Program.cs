using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasEnem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //entrada de dados
            Console.WriteLine("Informe o nome do candidato");
            string candidato = Console.ReadLine();

            Console.WriteLine("Informe a pontuação do candidato");
            double pontuacao = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a situação do candidato \n" +
                "P - Escolaridade publica 15% \n" +
                "A - Afrodescendente 10% \n" +
                "D - Deficiente 5% \n" +
                "N - Não se enquadra nas situações");

            string situacao = Console.ReadLine().ToLower();

            //atribuição de condições
            if (situacao == "p")

                Console.WriteLine("A pontuação do aluno será de: " + (pontuacao + (pontuacao * 15 / 100)));

            else if (situacao == "a")

                Console.WriteLine("A pontuação do aluno será de: " + (pontuacao + (pontuacao * 10 / 100)));

            else if (situacao == "d")

                Console.WriteLine("A pontuação do aluno será de: " + (pontuacao + (pontuacao * 5 / 100)));

            else if (situacao == "n")

                Console.WriteLine("A pontuação do aluno será a mesma: " + pontuacao);

            else

                Console.WriteLine("Opção inválida.");

            //execução do código
            Console.ReadKey();
        }
    }
}
