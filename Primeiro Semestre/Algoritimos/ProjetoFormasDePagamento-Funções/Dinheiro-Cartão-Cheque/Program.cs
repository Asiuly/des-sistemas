using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinheiro_Cartão_Cheque
{
    internal class Program
    {

        //declaração de variaveis que serão usadas em mais de um void
        static double total;
        static double desconto;
        static int parcela;
        static double acrescimo;

        static void Main(string[] args)
        {
            //variavel contador
            string denovo = "sim";

            //laço de repetição para registro de mais de uma compra
            while (denovo == "sim")
            {
                //entrada de dados do usuário
                Console.Write("\nQual valor total da sua compra?: ");
                total = double.Parse(Console.ReadLine());

                Console.Write("Existem 3 formas de pagamentos:" +
                    "\npara dinheiro digite (D)." +
                    "\npara cartão digite (CA)." +
                    "\npara cheque digite (CH)." +
                    "\nQual é a forma de pagemento desejado?" +
                    "\n> ");
                string forma = Console.ReadLine().ToUpper();

                //atribuição de condições à string (forma)
                switch (forma)
                {

                    //caso o usuário escolha dinheiro (D), execute esse caso
                    case "D":
                        //entrada de dados do usuário
                        Console.Write("Informe a porcentagem de desconto adquirida ao pagar a vista: ");
                        desconto = double.Parse(Console.ReadLine());

                        //execução da função autoral criada no void abaixo
                        dinheiro();

                        //exibição de variavel processada
                        Console.Write("\nO total da sua compra é de {0}", total.ToString("C"));
                        break;



                    //caso o usuário escolha cartão (CA), execute esse caso
                    case "CA":
                        //entrada de dados do usuário
                        Console.Write("Informe a quantidade de parcelas que deseja dividir sua compra: ");
                        parcela = int.Parse(Console.ReadLine());

                        //execução da função autoral criada no void abaixo
                        cartao();

                        //exibição de variavel processada
                        Console.Write("\nO valor de cada parcela é de {0}", total.ToString("C"));
                        break;



                    //caso o usuário escolha cheque (CH), execute esse caso
                    case "CH":
                        //entrada de dados do usuário
                        Console.Write("Informe a porcentagem de acréscimo adquirida ao pagar por cheque: ");
                        acrescimo = double.Parse(Console.ReadLine());

                        //execução da função autoral criada no void abaixo
                        cheque();

                        //exibição de variavel processada
                        Console.Write("\nO total da sua compra é de {0}", total.ToString("C"));
                        break;



                    //caso o usuário cometa um erro
                    default:
                        Console.WriteLine("\nVocê digitou algo errado.");
                        break;
                }

                //variavel que define se haverá mais repetições
                Console.WriteLine("\n\nDeseja registrar nova compra? (sim/não)");
                denovo = Console.ReadLine().ToLower();
            }

            //execução do código
            Console.ReadKey();

        }


        //criação da função autoral para cálculo da venda em dinheiro, pode ser executada inumeras vezes
        static void dinheiro()
        {
            //operador lógico equivalente a: total = total - (total * desconto/100)
            total -= total * desconto/100;
        }



        //criação da função autoral para cálculo da venda em cartão, pode ser executada inumeras vezes
        static void cartao()
        {
            //operador lógico equivalente a: total = total / parcela
            total /= parcela;
        }



        //criação da função autoral para cálculo da venda em cheque, pode ser executada inumeras vezes
        static void cheque()
        {
            //operador lógico equivalente a: total = total + (total * acrescimo/100)
            total += total * acrescimo/100;
        }
    }
}
