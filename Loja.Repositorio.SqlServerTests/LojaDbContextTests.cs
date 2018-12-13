using Microsoft.VisualStudio.TestTools.UnitTesting;
using Loja.Repositorio.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Loja.Dominio;

namespace Loja.Repositorio.SqlServer.Tests
{
    [TestClass()]
    public class LojaDbContextTests
    {
        private readonly LojaDbContext db = new LojaDbContext();

        public LojaDbContextTests()
        {
            db.Database.Log = LogarQuery;
        }

        private void LogarQuery(string query)
        {
            Debug.WriteLine(query);
        }

        [TestMethod()]
        public void LojaDbContextTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void InserirCategoriaTest()
        {


            var papelaria = new Categoria();
            papelaria.Nome = "Papelaria";
            db.Categorias.Add(papelaria);
            db.SaveChanges();

            //Assert.Fail();
        }



        [TestMethod()]
        public void InserirProdutoTest()
        {


            var produto = new Produto();
            produto.Categoria = db.Categorias.Find(1);
            produto.Nome = "Lápis Evolution Shapes";
            produto.Estoque = 100;
            produto.Preco = 1.23m;
            db.Produtos.Add(produto);
            db.SaveChanges();

            //Assert.Fail();
        }




        public void InserirProdutoComCategoriaTest()
        {


            var produto = new Produto();
            produto.Categoria = new Categoria { Nome = "Perfumaria" };
          //  produto.Categoria.Nome = "Perfumaria";
            produto.Nome = "Barbeador";
            produto.Estoque = 100;
            produto.Preco = 1.23m;
            db.Produtos.Add(produto);
            db.SaveChanges();

            //Assert.Fail();
        }


        public void EditarProdutoTest()
        {


            var produto = db.Produtos
                .Where(p => p.Nome.Contains("Lápis Evolution Shapes"))
                .FirstOrDefault();
        
          
            produto.Nome = "Caneta";
            produto.Estoque = 200;
            produto.Preco = 2.23m;
            
            db.SaveChanges();

            //Assert.Fail();
        }


        public void ExcluirProdutoTest()
        {


            var produto = db.Produtos.Find(1);
            db.Produtos.Remove(produto);
            db.SaveChanges();

           /// Assert.IsFalse(db.Produtos.Any()p => );
        }


    }
}