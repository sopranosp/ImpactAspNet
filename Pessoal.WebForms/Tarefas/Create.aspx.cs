using Pessoal.Dominio.Entidades;
using Pessoal.Repositorios.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pessoal.WebForms.Tarefas
{
    public partial class Create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        public List<Prioridade> ObterPrioridade()

        {

            return Enum.GetValues(typeof(Prioridade)).Cast<Prioridade>().ToList();
        }

        protected void gravarButton_Click(object sender, EventArgs e)
        {
            var tarefa = new Tarefa();
            tarefa.Concluida = concluidaCheckBox.Checked;
            tarefa.Nome = NomeTextBox1.Text;
            tarefa.Observacoes = observacoesTextBox.Text;

           /// enum TryParse(PrioridadeDro, out Prioridade prioridadeSelecionada);

        //enum.TryParse(PrioridadeDropDownList.SelectdValue, out Prioridade prioridadeSelecionada);
        //tarefa.Prioridade = PrioridadeSelecionada();

        //new TarefaRepositorio().Inserir(tarefa);
    }
    }
}