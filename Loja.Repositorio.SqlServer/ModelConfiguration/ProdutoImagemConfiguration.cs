using Loja.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace Loja.Repositorio.SqlServer.ModelConfiguration
{
    public class ProdutoImagemConfiguration : EntityTypeConfiguration<ProdutoImagem>
    {
        public ProdutoImagemConfiguration()
        {

            //ToTable("AllowWin")
            HasKey(pi => pi.ProdutoId);

            Property(pi => pi.ProdutoId)
                .HasColumnName("Produto_Id");


            Property(c => c.ContentType)
           .IsRequired()
           .HasMaxLength(50);
        }
    }
}