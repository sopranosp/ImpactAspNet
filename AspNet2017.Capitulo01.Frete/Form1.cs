using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AspNet2017.Capitulo01.Frete
{
    public partial class freteForm : Form
    {
        public freteForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void freteForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)

        {
            var erros = ValidarFormulario();
            if(erros.Count ==0)
            {
                Calcular();
            }

            else
            {
                MessageBox.Show(string.Join( Environment.NewLine ,erros),"Validação",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Calcular()
        {
            var percentual = 0m;
            var valor = Convert.ToDecimal(valortextBox.Text);
            var nordeste = new List<string>{"BA","PE","PB","CE","MA","PI","AL" };

            

            switch(ufcomboBox.Text.ToUpper())
            {
                case "SP":
                    percentual = 0.2m;
                    break;

                case "RJ":
                    percentual = 0.2m;
                    break;
                case "MG":
                    percentual = 0.35m;
                    break;
                case "AM":
                    percentual = 0.60m;
                    break;
                case "PA":
                    percentual = 0.50m;
                    break;
                case "PR":
                    percentual = 0.15m;
                    break;
                case "GO":
                    percentual = 0.30m;
                    break;

                case var uf when nordeste.Contains(uf):
                    percentual = 0.45m;
                    break;


                case null:
                    throw new NullReferenceException("Preencheu Nulo");
                  

                
                default:

                    break;
            }

            fretetextBox.Text = percentual.ToString("P1");
            totaltextBox.Text = (valor * (1 + percentual)).ToString("C2");

        }

        private List<string> ValidarFormulario()
        {
            var erros = new List<string>(); 

           if (clientetextBox.Text == string.Empty || string.IsNullOrEmpty(clientetextBox.Text) )
            {

                erros.Add(" Deu merda! o campo Cliente é obrigatório.");

            }

           if (ufcomboBox.SelectedIndex == - 1)
            {
                erros.Add("Acorda! Faz Favor de preencher o campo Uf.");


            }


           if(valortextBox.Text==string.Empty)

            {

                erros.Add("Atenção Jon! O campo Valor é obrigatório.");

            }

            else
            {

                if(!decimal.TryParse(valortextBox.Text,out decimal valor))
                {

                    erros.Add("O Campo valor esta com valor invalido.");
                }

            }

            return erros;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            valortextBox.Text ="";
            ufcomboBox.SelectedIndex = -1;
            clientetextBox.Text = string.Empty;
            fretetextBox.Clear();
            totaltextBox.Text = null;

            clientetextBox.Focus();

           // this.Close();

        }

        private void fecharbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
