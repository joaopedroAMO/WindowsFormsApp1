using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double renda = double.Parse(txtRenda.Text);
            double energia = double.Parse(txtEnergia.Text);
            double agua = double.Parse(txtAgua.Text);
            double tv = double.Parse(txtTv.Text);
            double alimentasao = double.Parse(txtAli.Text);
            double outrosGastos = double.Parse(txtOutros.Text);

            double gasto = energia + agua + tv + alimentasao + outrosGastos;
            double saldo = renda - energia - agua - tv - alimentasao - outrosGastos;

            lblTotal.Text = gasto.ToString("C", new CultureInfo("pt-BR"));
            lblSaldo.Text = saldo.ToString("C", new CultureInfo("pt-BR"));
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtRenda.Clear();
            txtEnergia.Clear();
            txtAgua.Clear();
            txtTv.Clear();
            txtAli.Clear();
            txtOutros.Clear();

            txtRenda.Focus();

            lblTotal.Text = "R$ 00,00";
            lblSaldo.Text = "R$ 00,00";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
