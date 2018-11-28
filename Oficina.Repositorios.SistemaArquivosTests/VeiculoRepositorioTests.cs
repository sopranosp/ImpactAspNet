using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Dominio;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaArquivos.Tests
{
    [TestClass()]
    public class VeiculoRepositorioTests
    {
        [TestMethod()]
        public void VeiculoRepositorioTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void InserirTest()
        {
            var veiculo = new Veiculo();

            //veiculo.Id = 1;
           
            veiculo.Ano = 2014;
            veiculo.Cambio = Cambio.Automatico;
            veiculo.Combustivel = Combustivel.Alcool;
            veiculo.Observacao = "Observação";
            veiculo.Placa = "CTM4010";

            veiculo.Cor = new CorRepositorio().Selecionar(1);
            veiculo.Modelo = new ModeloRepositorio().Selecionar(1);



            new VeiculoRepositorio().Inserir(veiculo);
        }
    }
}