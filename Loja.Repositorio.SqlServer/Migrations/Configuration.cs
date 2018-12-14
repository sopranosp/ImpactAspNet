namespace Loja.Repositorio.SqlServer.Migrations
{
    using Loja.Dominio;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Loja.Repositorio.SqlServer.LojaDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Loja.Repositorio.SqlServer.LojaDbContext";
        }

        protected override void Seed(LojaDbContext context)
        {
          if (!context.Produtos.Any())
            {
                context.Produtos.AddRange(ObterProdutos());


                context.SaveChanges();
            }


        }


        private IEnumerable<Produto> ObterProdutos()
        {
            var barbeador = new Produto();

            barbeador.Categoria = new Categoria { Nome = "Perfumaria" };
            //produto.Categoria.Nome = "Perfumaria";
            barbeador.Estoque = 8;
            barbeador.Nome = "Barbeador";
            barbeador.Preco = 22.08m;

            var grampeador = new Produto();

            grampeador.Categoria = new Categoria { Nome = "Papelaria" };
            grampeador.Categoria.Nome = "Perfumaria";
            grampeador.Estoque = 9;
            grampeador.Nome = "Grampeador";
            grampeador.Preco = 10m;

            return new List<Produto> { barbeador, grampeador };

            // db.Produtos.Add(produto);
        }
    }
}
