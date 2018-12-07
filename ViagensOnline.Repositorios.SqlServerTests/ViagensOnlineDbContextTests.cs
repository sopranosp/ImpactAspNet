using Microsoft.VisualStudio.TestTools.UnitTesting;
using ViagensOnline.Repositorios.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViagensOnline.Dominio;

namespace ViagensOnline.Repositorios.SqlServer.Tests
{


    [TestClass()]
    public class ViagensOnlineDbContextTests
    {

        private readonly ViagensOnlineDbContext db = new ViagensOnlineDbContext();

        [TestMethod()]
        public void InserirTest()
        {

            Destino destino = new Destino();
            destino.Cidade = "Silent Hill";
            destino.Nome = "Harry Manson";
            destino.NomeImagem = "Silent.jpeg";
            destino.Pais = "EUA";


            db.Destinos.Add(destino);
            db.SaveChanges();



        }


        [TestMethod()]
        public void AtualizarTest()
        {


            var destino = db.Destinos.Find(2);
            destino.Pais = "Brasil";
            db.SaveChanges();
           
            //---------------------///

            destino = db.Destinos.Find(1);
            Assert.AreEqual(destino.Pais, "Brasil");


        }



        [TestMethod()]
        public void ExcluirTest()
        {

            var destino = db.Destinos.Find(2);
            db.Destinos.Remove(destino);
          
            db.SaveChanges();

            //---------------------///

     
          


        }

    }
}