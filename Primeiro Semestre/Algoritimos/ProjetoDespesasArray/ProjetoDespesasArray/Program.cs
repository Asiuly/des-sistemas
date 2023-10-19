using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ProjetoDespesasArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Despesas = {"água", "energia", "telefone", "internet"};
            double[] valor = { 115.5, 225, 98.55, 100.25 };
            double total = 0;

            for (int i=0; i<=3; i++)
            {
             Console.WriteLine("Despesa: {0} tem o valor de: {1}", Despesas[i], valor[i].ToString("C"));
             total += valor[i]; 
            }

            Console.WriteLine("\no valor total das contas foi de {0}", total.ToString("C"));


            Console.ReadKey();





        }
    }
}
