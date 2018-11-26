using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AspNetVS2017.Capitulo01.Troco
{
    public partial class TrocoForm : Form
    {
        public TrocoForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TrocoForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void CalcularBtn_Click(object sender, EventArgs e)
        {
            decimal valorCompra = Convert.ToDecimal(ValorCompratextBox.Text);
            decimal valorPago = Convert.ToDecimal(valorpagotextBox.Text);
            decimal valorTroco = valorPago - valorCompra;
            valortrocotextBox.Text = valorTroco.ToString("c2");


            var moedas = new decimal[]{ 1, 0.5m, 0.25m, 0.1m, 0.05m, 0.01m };

            for (int i =0; i < moedas.Length; i++)
            {

                moedaslistView.Items[i].Text = ((int)(valorTroco / moedas[1])).ToString();
                valorTroco %= moedas[i];
                ;

            }


            //int moedas1 = (int)(valorTroco / 1);
            //valorTroco %= 1;

            //int moedas050 = (int)(valorTroco / 0.5m);
            //valorTroco %= 0.5m;

            //int moedas025 = (int)(valorTroco / 0.25m);
            //valorTroco %= 0.25m;

            //int moedas010 = (int)(valorTroco / 0.10m);
            //valorTroco %= 0.10m;

            //int moedas001 = (int)(valorTroco / 0.01m);
            //valorTroco %= 0.01m;


            //moedaslistView.Items[0].Text = moedas1.ToString();

            //moedaslistView.Items[1].Text = moedas050.ToString();

            //moedaslistView.Items[2].Text = moedas025.ToString();

            //moedaslistView.Items[3].Text = moedas010.ToString();


            //moedaslistView.Items[4].Text = moedas001.ToString();




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void moedaslistView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
