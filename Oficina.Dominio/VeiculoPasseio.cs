using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Dominio
{
   public class VeiculoPasseio : Veiculo

    {
        // ToDo Herança(:) com a Classe veiculo.

        public Carroceria Carroceria { get; set; }


        ////ToDo poliformismo por substituição Overide (Sobrescrita).

        public override List<string> Validar()
        {
            var erros = ValidarBase();

            if (!Enum.IsDefined(typeof(Carroceria),Carroceria))
            {
                erros.Add($"A Corroceria Informada ({Carroceria}) não é valida");
            }

            return erros;
        }
    }
}
