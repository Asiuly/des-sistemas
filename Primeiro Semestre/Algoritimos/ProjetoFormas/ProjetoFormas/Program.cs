using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFormas
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string denovo = "s";
            while (denovo == "s")
            {
                Console.Write("Opções de forma para cálculo:" +
                    "\nQuadrado" +
                    "\nRetângulo" +
                    "\nTrapézio" +
                    "\nLosango" +
                    "\n\nEscolha a forma que você deseja calcular a área: ");
                string forma = Console.ReadLine().ToLower();

                switch (forma)
                {
                    case "quadrado":
                        areaQuadrado();
                        break;

                    case "retângulo":
                        areaRetangulo();
                        break;

                    case "losango":
                        areaLosango();
                        break;

                    case "trapezio":
                        areaTrapezio();
                        break;

                    default:
                        Console.WriteLine("Você digitou algo errado... ");
                        break;

                }

                Console.WriteLine("\nDeseja cadastrar uma nova forma? (s/n) ");
                denovo = Console.ReadLine().ToLower();
            }

            Console.ReadKey();

        }

        static void areaQuadrado()
        {
            Console.Write("Digite em centímetros o tamanho do lado do quadrado: ");
            double medida = double.Parse(Console.ReadLine());

            Console.WriteLine("\nA Área da sua forma é " + medida * medida);
        }

        static void areaRetangulo()
        {
            double[] medida = new double[2];
            Console.Write("Digite em centímetros a base do retângulo: ");
            medida[0] = double.Parse(Console.ReadLine());

            Console.Write("Digite em centímetros a altura do retângulo: ");
            medida[1] = double.Parse(Console.ReadLine());

            Console.WriteLine("\nA Área da sua forma é " + medida[0] * medida[1]);
        }

        static void areaTrapezio()
        {
            double[] medida = new double[3];
            Console.Write("Digite em centímetros a base maior do trapézio: ");
            medida[0] = double.Parse(Console.ReadLine());

            Console.Write("Digite em centímetros a base menor do trapézio: ");
            medida[1] = double.Parse(Console.ReadLine());

            Console.Write("Digite em centímetros a altura do trapézio: ");
            medida[3] = double.Parse(Console.ReadLine());

            Console.WriteLine("\nA Área da sua forma é " + ((medida[0] + medida[1]) * medida[2])/2);
        }

        static void areaLosango()
        {
            double[] medida = new double[2];
            Console.Write("Digite em centímetros a diagonal maior do losângo: ");
            medida[0] = double.Parse(Console.ReadLine());

            Console.Write("Digite em centímetros a diagonal menor do losângo: ");
            medida[1] = double.Parse(Console.ReadLine());

            Console.WriteLine("\nA Área da sua forma é " + (medida[0] * medida[1])/2);
        }
    }
}
