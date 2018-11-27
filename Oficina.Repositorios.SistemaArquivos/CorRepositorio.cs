using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.IO;
//using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaArquivos
{
    public class CorRepositorio
    {
        public List<cor> Selecionar()
        {

            var cores = new List<cor>();
            foreach (var Linha in File.ReadAllLines("Dados\\Cor.txt"))
            {
                var cor = new cor();

                cor.Id = Convert.ToInt32(Linha.Substring(0,5));
                cor.Cor = Linha.Substring(5);
                cores.Add(cor);


            }

            return cores;

        }





    }
}
