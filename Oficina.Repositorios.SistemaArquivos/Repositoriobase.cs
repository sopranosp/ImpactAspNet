using System;
using System.Configuration;
using System.IO;

namespace Oficina.Repositorios.SistemaArquivos
{
    public class Repositoriobase
    {



   



        public string ObterCaminhoCompleto( string caminho)
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
            ConfigurationManager.AppSettings["caminhoArquivoCor"]);
        }



        private string PathCombine(object baseDirectory , object p)

        {
            throw new NotImplementedException();

        }

    }
}