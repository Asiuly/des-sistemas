using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvinhaSetembro
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Entrada de dados
            Console.Write("Informe seu gênero (M/F):");
            string genero = Console.ReadLine().ToUpper();

            //Atribuição de condições
            if (genero == "M")
                Console.WriteLine("O usuário é do sexo masculino");

            else if (genero == "F")
                Console.WriteLine("O usuário é do sexo feminino ");

            else
                Console.WriteLine("o sexo digitado não é valido");

            //Execução de código
            Console.ReadKey();  

        }
    }
}
