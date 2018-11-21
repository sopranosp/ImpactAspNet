using System;
using System.Windows.Forms;

namespace AspNetVS2017.Capitulo01.Variaveis
{
    public partial class VariaveisForm : Form
    {
        int x = 32;
        int w = 45;
        int y = 16;
        int z = 32;

        public VariaveisForm()
        {
            InitializeComponent();
        }

      

        private void VariaveisForm_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void aritméticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = 2;
            int b = 6;
            decimal c = 10m;
            decimal d = 13m;
            //resultadoListbox.Items.Add("a ="+a);
            resultadoListbox.Items.Add(string.Concat("a=", a));
            resultadoListbox.Items.Add("b ="+b);
            resultadoListbox.Items.Add(string.Format("c = {0}",c));
            resultadoListbox.Items.Add($"d ={d}");
            resultadoListbox.Items.Add("--------------------------");
            resultadoListbox.Items.Add("c*d=" + (c * d));
            resultadoListbox.Items.Add("c/d=" + (c / d));
            resultadoListbox.Items.Add("d % a=" + (d % a));
            resultadoListbox.Items.Add("a + b=" + (a + b));
            object novoObjeto = 123;
            novoObjeto = "Camelo";








            //int meuInteiro = 10;
            //decimal valor = 22.39m;
            //string nome = "Luiz";
            //bool aprovado = true;
            //DateTime datanascimento = new DateTime(2018, 12, 25);
            //int fx = 14;
            //var g = "sobrenome";
            //char sexo = 'f';
            //var @decimal = 0.2m;
            //if (@decimal > 0)
            //    'certo'
        }

        private void operacoesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reduzidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var x = 5;
            resultadoListbox.Items.Add("x =" + x);
            resultadoListbox.Items.Add(("x = ") + (x -= 3));
        }

        private void incrementaisDecrementaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a;
            a = 5;
            resultadoListbox.Items.Add("Exemplo Pré-incremental");
            resultadoListbox.Items.Add("Valor de a " + a);
            resultadoListbox.Items.Add(" 2 + ++a " +(2+ ++a));


            a = 5;
            resultadoListbox.Items.Add("Exemplo Pos-incremental");
            resultadoListbox.Items.Add("Valor de a " + a);
            resultadoListbox.Items.Add(" 2 + a++a " + (2 + a++));
            resultadoListbox.Items.Add("a= " + a);



        }

        private void booleanasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApresentarVariaveis();

            resultadoListbox.Items.Add(new string('-', 50));
            resultadoListbox.Items.Add(("w <= x ") + (w <= x));
            resultadoListbox.Items.Add(("x == z ") + (x == z));
            resultadoListbox.Items.Add(("x != z ") + (z != x));
            resultadoListbox.Items.Add(("w != x ") + (w != x));

        }
        
        private void ApresentarVariaveis()
        {
            resultadoListbox.Items.Add("x= " + x);
            resultadoListbox.Items.Add("w= " + w);
            resultadoListbox.Items.Add("y= " + y);
            resultadoListbox.Items.Add("z= " + z);
        }

        private void logicasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ApresentarVariaveis();
            resultadoListbox.Items.Add(("w <= x || y ==16 ") + (w <= x ||  y==16) ) ;
            resultadoListbox.Items.Add(("x ==zz &&  x != z =") + (x!=z));
         

        }

        private void operacoesTernariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ano;
            ano = 2016;
            resultadoListbox.Items.Add(string.Format("O ano {0} tal é Bissexto? {1}.", ano, (ano % 4 ==0) ? "Sim" :"Não"));
            resultadoListbox.Items.Add(string.Format("O ano {0} tal é Bissexto? {1}.", ano, DateTime.IsLeapYear(ano) ? "Sim" : "Não"));

        }
    }
}
