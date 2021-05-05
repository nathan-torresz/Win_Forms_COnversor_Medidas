using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Conversor_Medidas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            float valor;
            try
            {
                valor = float.Parse(tbValor.Text);
            }
            catch(Exception exception)
            {
                MessageBox.Show("Erro! Digite um valor numerico!");
                valor = 0;
                tbValor.Clear();
                tbValor.Focus();
            }

            if (rbMetros.Checked) valor /= 100;
            else if (rbCentim.Checked) valor *= 100;

            string sValor = valor.ToString();
            if (cbExibir.Checked)
            {
                if (rbMetros.Checked) sValor += " m";
                else if (rbCentim.Checked) sValor += " cm";

            }    

            lbValorConvertido.Text = sValor;
        }

        private void btnConvert_MouseEnter(object sender, EventArgs e)
        {
            if(rbCentim.Checked) lbInstruct.Text ="Converter metro(s) em cm";
            else if (rbMetros.Checked)lbInstruct.Text = "Converter cm em metros";
        }

        private void btnConvert_MouseLeave(object sender, EventArgs e)
        {
            lbInstruct.Text = "Digite o valor para conversão";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
