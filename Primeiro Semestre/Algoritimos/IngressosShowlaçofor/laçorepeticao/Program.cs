using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laçorepeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarações de variaveis a serem utilizadas
            double faturamento = 0;
            double ingresso;
            int NumEstudantes = 0;

            //Laço de repetição para cadastrar os 30 ingressos
            for (int i = 0; i<=30; i++)
            {
                //condição para mudar o preço do ingresso após uma certa quantidade vendida
                if (i <= 10)
                    ingresso = 100;

                else if (i <= 20)
                    ingresso = 150;

                else
                    ingresso = 200;

                //Entrada de informações do usuário
                Console.Write("Olá, o preço do ingresso é {0}" +
                    " caso você for estudante o preço cai para a metade, você é estudante? (S/N)", ingresso.ToString("C"));
                string estudante = Console.ReadLine().ToUpper();

                //atribuição de condições para totalizar o preço final do ingresso de acordo com a entrada acima
                if (estudante == "S")
                { 
                    ingresso /= 2;
                    Console.WriteLine("Portanto, o preço do ingresso é de {0}\n", ingresso.ToString("C"));
                    //atribuindo contagem de quantos ingressos meia
                    NumEstudantes += 1;
                }

                else if (estudante == "N")
                    Console.WriteLine("Portanto, o preço do ingresso continua sendo {0}\n", ingresso.ToString("C"));

                //default
                else
                    Console.WriteLine("Você digitou uma opção inválida");

                //operador lógico pra totalizar faturamento
                faturamento += ingresso;
            }

            //exibição de variaveis finais
            Console.WriteLine("\n\nO total faturado com ingressos foi de {0}" +
                "\n\nO número de ingressos vendidos para estudantes foi de {1}", faturamento.ToString("C"), NumEstudantes);

            Console.WriteLine("\nAlém disso, o número de ingressos vendidos integralmente foi de " + (30 - NumEstudantes));

            //Execução do Código
            Console.ReadKey();    
        }
    }
}
