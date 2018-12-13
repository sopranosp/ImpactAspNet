﻿using Loja.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace Loja.Repositorios.SqlServer.ModelConfiguration
{
    public class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(200);
            Property(p => p.Preco)
                .HasPrecision(9, 2);

            HasRequired(p => p.Categoria);

            HasOptional(p => p.ProdutoImagem)
                .WithRequired(pi => pi.Produto)
                .WillCascadeOnDelete(true);
        }
    }
}