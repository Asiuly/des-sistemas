using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalhadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resp = "S";
            int cont = 0;
            double salariototal = 0;

            while (resp == "S")
            {
                Console.Write("Digite seu salário: R$");
                double salario = double.Parse(Console.ReadLine());

                Console.Write("\nINFORME: \n" +
                "Digite A para Assalariado \n" +
                "Digite C para Comissionado \n" +
                "Digite H para Horista \n" +
                "\nQual foi a forma de contratação do seu atual emprego?: ");
                string contratacao = Console.ReadLine().ToUpper();

                switch (contratacao)
                {
                    case "A":
                        Console.Write("Você é assalariado! \n" +
                        "Portanto, informe a porcentagem de imposto que será descontado de seu salário: ");
                        int porcentagem = int.Parse(Console.ReadLine());

                        salario -= salario * porcentagem / 100;
                        break;

                    case "C":
                        Console.Write("Você é comissionado!\n" +
                            "Portanto, informe a porcentagem recebida de suas vendas: ");
                        int porcentagemVendas = int.Parse(Console.ReadLine());

                        Console.Write("Agora, informe, em reais, suas vendas do mês: ");
                        double vendas = double.Parse(Console.ReadLine());

                        salario += vendas * porcentagemVendas / 100;
                        break;

                    case "H":
                        Console.Write("Você é Horista! \n" +
                            "Portanto, informe o valor da sua hora extra, em reais: ");
                        double horasExtra = double.Parse(Console.ReadLine());

                        Console.Write("Agora, informe a quantidade de horas extra realizadas esse mês: ");
                        horasExtra *= int.Parse(Console.ReadLine());

                        salario += horasExtra;
                        break;

                    default:
                        Console.WriteLine("Você digitou uma opção invalida!");
                        return;
                }
              
            Console.WriteLine("\nAssim, seu salário líquido é de {0}", salario.ToString("C"));

            Console.WriteLine("Deseja cadastrar outro funcionário?(S/N): ");
            resp = Console.ReadLine().ToUpper();

            cont++;
            salariototal += salario;
           
            }

            Console.WriteLine("O número de funcionários cadastrados foi de " + cont + 
                "\n Já soma dos salários de todos eles foi de " + salariototal + 
                "\n Portanto, a média da empresa é de: " + salariototal / cont);

            //execução do código 
            Console.ReadKey();

        }
    }
}
