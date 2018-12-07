using System;
using System.Collections.Generic;

namespace Oficina.Dominio
{
    public abstract class Veiculo :Object
    {
        public Veiculo()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id
        {
            get;
            set;
        }
        //private String placa;

        //public string Placa
        //{
        //    get
        //    {
        //        return Placa.ToUpper();
        //    }
        //    set
        //    {
        //        Placa = value.ToUpper();
        //    }
        //}



        private string placa;


        //ToDo Encapsulamento.
        public string Placa
        {
            get {
                 return placa?.ToUpper();

                }
            set {
                  placa = value?.ToUpper();
                 }
        }

        public int Ano { get; set; }
        public string Observacao { get; set; }
        public Modelo Modelo { get; set; }
        public Cor Cor { get; set; }
        public Combustivel Combustivel { get; set; }
        public Cambio Cambio { get; set; }


        public abstract List<string> Validar();

        public List<string> ValidarBase()
       {
            var erro = new List<string>();
            if (Ano < 1980 || Ano > DateTime.Now.Year +1)

            {
                erro.Add($"o Ano informado ({Ano}) não é valido");
            }

            

            return erro;
       }



        public override string ToString()
        {
            



            return String.Format("{0} {1} {2}",Modelo.Marca.Nome, Modelo.Nome, Placa);
            //return base.ToString();
        }


        public DateTime Agora
        {
            get { return DateTime.Now; }
            
        } 

    }


    

}