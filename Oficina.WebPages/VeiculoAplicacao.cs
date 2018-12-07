using Oficina.Dominio;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Oficina.WebPages
{
    public class VeiculoAplicacao
    {
        private readonly CorRepositorio corRepositorio = new CorRepositorio();
        private readonly MarcaRepositorio marcaRepositorio = new MarcaRepositorio();
        private readonly ModeloRepositorio modeloRepositorio = new ModeloRepositorio();
        private readonly VeiculoRepositorio veiculoRepositorio = new VeiculoRepositorio();


        public VeiculoAplicacao()
        {

            
            PopularControles();
         
          

        }

        public void Inserir()
        {
            try
            {
                var veiculo = new VeiculoPasseio();
                var formulario = HttpContext.Current.Request.Form;

                veiculo.Ano = Convert.ToInt32(formulario["ano"]);
                veiculo.Cambio = (Cambio)Convert.ToInt32(formulario["cambio"]);
                veiculo.Combustivel = (Combustivel)Convert.ToInt32(formulario["combustivel"]);

                veiculo.Cor = corRepositorio.Selecionar(Convert.ToInt32(formulario["cor"]));
                veiculo.Modelo = modeloRepositorio.Selecionar(Convert.ToInt32(formulario["modelo"]));

                veiculo.Observacao = formulario["observacao"];
                veiculo.Placa = formulario["placa"]  /*.ToUpper()*/;
                veiculo.Carroceria = Carroceria.Hatch;

                veiculoRepositorio.Inserir(veiculo);
            }

            catch(FileNotFoundException ex)
            {
                // HttpContext.Current.Items.Add("MensagemErro", $"Atenção Arquivo {ex.Filename} não enconrado.");
                HttpContext.Current.Items.Add("MensagemErro", $"Arquivo {ex.FileName} não encontrado abestado");
                throw;

            }


      
      catch (DirectoryNotFoundException)
            {
                // HttpContext.Current.Items.Add("MensagemErro", $"Atenção Arquivo {ex.Filename} não enconrado.");
                HttpContext.Current.Items.Add("MensagemErro", $"Diretório não encontrado abestado");
                throw;

            }



            catch (UnauthorizedAccessException )
            {
                // HttpContext.Current.Items.Add("MensagemErro", $"Atenção Arquivo {ex.Filename} não enconrado.");
                HttpContext.Current.Items.Add("MensagemErro", $"Acesso negado abestado");
                throw;

            }

            catch (Exception)
            {


                // HttpContext.Current.Items.Add("MensagemErro", $"Atenção Arquivo {ex.Filename} não enconrado.");
                HttpContext.Current.Items.Add("MensagemErro", $"Ocorreu um erro abestado");
                throw;

            }


            finally
            {



                //é sempre usado tanto erro como sucesso
            }

        }

        public List<Marca> Marcas { get; private set; }
        
        public string MarcaSelecionada { get; set; }
        public List<Cor> Cores { get; private set; }
        public List<Combustivel> Combustiveis { get; private set; }
        public List<Cambio> Cambios { get; private set; }
        public List<Modelo> Modelos { get; private set; } = new List<Modelo>();

        private void PopularControles()
        {
            Marcas = marcaRepositorio.Selecionar();
            Cores = corRepositorio.Selecionar();
            Combustiveis = Enum.GetValues(typeof(Combustivel)).Cast<Combustivel>().ToList();
            Cambios = Enum.GetValues(typeof(Cambio)).Cast<Cambio>().ToList();

            MarcaSelecionada = HttpContext.Current.Request.QueryString["marcaId"];


            //if (MarcaSelecionada.Length > 0 )
            //{

            //}



            if (!string.IsNullOrEmpty(MarcaSelecionada))
            {
                Modelos = modeloRepositorio
                   .SelecionarPorMarca(Convert.ToInt32(MarcaSelecionada));

                //MarcaSelecionada = HttpContext.Current.Request.QueryString["marcaid"];
            }

            

        }


    }
}