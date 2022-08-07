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

namespace testeProjeto
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0, contaFinal =0;
        string operacaoS = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            
            valor1 = decimal.Parse(Resultado.Text, CultureInfo.InvariantCulture);
            Resultado.Text = "";
            operacaoS = "SOMA";
            label1.Text = "+";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + "5";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(Resultado.Text, CultureInfo.InvariantCulture);
            Resultado.Text = "";
            operacaoS = "SUBTRACAO";
            label1.Text = "-";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(Resultado.Text, CultureInfo.InvariantCulture);
            if (operacaoS == "SOMA")
            {
                contaFinal = valor1 + valor2;
            }
            else if (operacaoS == "DIVISAO")
            {
                contaFinal = valor1 / valor2;
            }
            else if (operacaoS == "MULTI")
            {
                contaFinal = valor1 * valor2;
            }
            else if (operacaoS == "SUBTRACAO")
            {
                contaFinal = valor1 - valor2;
            }

            Resultado.Text = contaFinal.ToString();
            label1.Text = "";
        }

        private void Resultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + "8";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + "9";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + "6";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + "4";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + "2";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(Resultado.Text, CultureInfo.InvariantCulture);
            valor1 = valor1 * valor1;
            Resultado.Text = valor1.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(Resultado.Text, CultureInfo.InvariantCulture);
            Resultado.Text = "";
            operacaoS = "DIVISAO";
            label1.Text = "/";
        }

        private void button17_Click(object sender, EventArgs e)
        {

                valor1 = decimal.Parse(Resultado.Text, CultureInfo.InvariantCulture);
                Resultado.Text = "";
                operacaoS = "MULTI";
                label1.Text = "*";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Resultado.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
             Resultado.Text = Resultado.Text.Remove(Resultado.Text.Length - 1);

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
 
            Resultado.Text = Resultado.Text + "1";
        }

        private void button4_Click(object sender, EventArgs e)
        {
         
            Resultado.Text = Resultado.Text + ".";
        }
        
    }
}
