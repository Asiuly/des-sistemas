using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria
{
    public partial class Form1 : Form
    {
        public string pizza;
        public double valorPizza;
        public string borda;
        public double valorBorda;
        public string selecionadasRefri = "";
        public string selecionadasSucos = "";
        public double valorRefri = 0;
        public double valorSuco = 0;
        public double total;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnFatura_Click(object sender, EventArgs e)
        {
            //selecionadas Refrigerantes

            if (chkCervejaGarrafa.Checked)
            {
                selecionadasRefri += "Cerveja de Garrafa = R$5,50\n\n";
                valorRefri += 5.50;
            }

            if (chkCervejaLata.Checked)
            {
                selecionadasRefri += "Cerveja de Lata = R$4,00\n\n";
                valorRefri += 4;
            }

            if (chkCocaLata.Checked)
            {
                selecionadasRefri += "Coca-Cola de Lata = R$3,50\n\n";
                valorRefri += 3.50;
            }

            if (chkCocaLitro.Checked)
            {
                selecionadasRefri += "Coca-Cola de Litro = R$5,10\n\n";
                valorRefri += 5.10;
            }

            if (chkGuaranaLata.Checked)
            {
                selecionadasRefri += "Guaraná de Lata = R$2,85\n\n";
                valorRefri += 2.85;
            }

            if (chkGuaranaLitro.Checked)
            {
                selecionadasRefri += "Guaraná de Litro = R$3,50\n\n";
                valorRefri += 3.50;
            }

            //selecionados Sucos
            if (chkAbacaxiCopo.Checked)
            {
                selecionadasSucos += "Suco de Abacaxi no copo = R$4,20\n\n";
                valorSuco += 4.20;
            }

            if (chkAbacaxiJarra.Checked)
            {
                selecionadasSucos += "Suco de abacaxi na jarra = R$6,05\n\n";
                valorSuco += 6.05;
            }

            if (chkLaranjaCopo.Checked)
            {
                selecionadasSucos += "Suco de laranja no copo = R$4,25\n\n";
                valorSuco += 4.25;
            }

            if (chkLaranjaJarra.Checked)
            {
                selecionadasSucos += "Suco de laranja na jarra = R$6,30\n\n";
                valorSuco += 6.30;
            }

            if (chkMaracujaCopo.Checked)
            {
                selecionadasSucos += "Suco de maracujá no copo = R$4,10\n\n";
                valorSuco += 4.10;
            }

            if (chkMaracujaJarra.Checked)
            {
                selecionadasSucos += "Suco de maracujá na jarra = R$6,50\n\n";
                valorSuco += 6.50;
            }

            //IFS DA BORDA
            if (rdbSem.Checked)
            {
                borda = "Sem Borda";
                valorBorda = 0;
            }

            else if (rdbBordaCatupiry.Checked) 
            {
                borda = "Catupiry";
                valorBorda = 3.45;
            }

            else if (rdbBordaCheddar.Checked)
            {
                borda = "Cheddar";
                valorBorda = 4.65;
            }

            //IFS DAS PIZZAS
            if (rdbModaCasa.Checked)
            {
                valorPizza = 17.50;
                pizza = "À Moda da casa";
            }

            else if (rdbAtum.Checked)
            {
                valorPizza = 17.85;
                pizza = "Atum";
            }

            else if (rdbAtum.Checked)
            {
                valorPizza = 17.85;
                pizza = "Atum";
            }

            else if (rdbBaiana.Checked)
            {
                valorPizza = 16.10;
                pizza = "Baiana";
            }

            else if (rdbBrocolis.Checked)
            {
                valorPizza = 12.00;
                pizza = "Brócolis";
            }

            else if (rdbCalabresa.Checked)
            {
                valorPizza = 20.50;
                pizza = "Calabresa";
            }

            else if (rdbMussarela.Checked)
            {
                valorPizza = 16.70;
                pizza = "Mussarela";
            }

            else if (rdbMussarela.Checked)
            {
                valorPizza = 16.70;
                pizza = "Mussarela";
            }

            else if (rdbQuatroQueijos.Checked)
            {
                valorPizza = 15.50;
                pizza = "Quatro Queijos";
            }

            else if (rdbStrogonoff.Checked)
            {
                valorPizza = 22.75;
                pizza = "Quatro Queijos";
            }
            total = valorPizza + valorBorda + valorRefri + valorSuco;

            MessageBox.Show($"{txtCliente.Text}\n" +
                $"\nPizza: {pizza} {valorPizza:C}\n" +
                $"\nBorda: {borda} {valorBorda:C}\n" +
                $"\n{selecionadasRefri}" +
                $"{selecionadasSucos}" +
                $"{total:C}");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            rdbQuatroQueijos.Checked = false;
            rdbStrogonoff.Checked = false;
            rdbMussarela.Checked = false;
            rdbAtum.Checked = false;
            rdbBaiana.Checked = false;
            rdbBordaCatupiry.Checked = false;
            rdbBordaCheddar.Checked = false;
            rdbBrocolis.Checked = false;
            rdbCalabresa.Checked = false;
            rdbModaCasa.Checked = false;
            rdbSem.Checked= false;
            chkAbacaxiCopo.Checked = false;
            chkAbacaxiJarra.Checked = false;
            chkCervejaGarrafa.Checked = false;
            chkCervejaLata.Checked = false;
            chkCocaLata.Checked = false;
            chkCocaLitro.Checked = false;
            chkGuaranaLata.Checked = false;
            chkGuaranaLitro.Checked = false;
            chkLaranjaCopo.Checked = false;
            chkLaranjaJarra.Checked = false;
            chkMaracujaCopo.Checked = false;
            chkMaracujaJarra.Checked = false;

            total = 0;
            valorPizza = 0;
            valorBorda = 0;
            valorRefri = 0;
            valorSuco = 0;

            selecionadasSucos = "";
            selecionadasRefri = "";
            txtCliente.Text = "";
            pizza = "";
            borda = "";

        }
    }
}
