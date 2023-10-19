using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funçãovoid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Executando função autoral
            cadastroNome();
            Console.WriteLine("\nLegal agora denovo");

            //repetindo função (zera variaveis)
            cadastroNome();

            //execução do código
            Console.ReadKey();
        }

        //Cadastro de função
        static void cadastroNome()
        {
            //código que será realizado ao executar a função cadastroNome()
            Console.Write("\nInsira seu primeiro nome: ");
            string n1 = Console.ReadLine();

            Console.Write("Insira seu segundo nome: ");
            string n2 = Console.ReadLine();

            Console.WriteLine("Seu nome completo é {0} {1}", n1, n2);
        }

    }
}
