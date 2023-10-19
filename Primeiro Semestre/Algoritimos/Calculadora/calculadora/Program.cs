using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //informações ao usuário
            Console.WriteLine("Digite dois números e uma operação, realizaremos ela!");

            //entrada de dados
            Console.Write("Digite o 1º número: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o 2º número: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a operação desejada( * , / , + , -):  ");
            string operacao = Console.ReadLine();

            //atribuição de condição
            if (operacao == "*")
                Console.Write("\nVocê escolheu a multiplicação, o resultado da sua operação é: " + (n1 * n2));

            else if (operacao == "/")
                Console.Write("\nVocê escolheu a divisão, o resultado da sua operação é: " + (n1 / n2));

            else if (operacao == "+")
                Console.Write("\nVocê escolheu a adição, o resultado da sua operação é: " + (n1 + n2));

            else if (operacao == "-")
                Console.Write("\nVocê escolheu a subtração, o resultado da sua operação é: " + (n1 - n2));

            else
                Console.Write("\nVocê não digitou uma operação válida, tente novamente :)");

            //Execução do código
            Console.ReadKey();
        }
    }
}
