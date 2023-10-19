using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdadesWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variavel para o while
            int cont = 1;

            //variaveis que serão processadas dentro do while
            int totalH = 0;
            int totalM = 0;
            int mulheres = 0;
            int homens = 0;

            //laço de repetição
            while (cont <= 7)
            {
                //entrada de dados do usuário (se repetirá junto com o laço)
                Console.WriteLine("Informe seu gênero(M/H): ");
                string genero = Console.ReadLine().ToUpper();

                Console.WriteLine("Qual é a sua idade?: ");
                int idade = int.Parse(Console.ReadLine());

                //condição que se repetirá junto com o laço (será aplicada para cada repetição)
                if (genero == "M")
                {
                    totalM += idade;
                    mulheres += 1;
                }
                else if (genero == "H")
                {
                    totalH += idade;
                    homens += 1;
                }

                //default
                else
                {
                    Console.Write("Você digitou um gênero inválido.");
                }

                //subindo contador
                cont++;
            }

            //exibição das variaveis processadas
            Console.WriteLine("sobre as " + mulheres + " mulheres, a média de suas idades é " + (totalM / mulheres));

            Console.WriteLine("sobre os " + homens + " homens, a média de suas idades é " + (totalH / homens));

            //execução do código
            Console.ReadKey();

        }
    }
}
