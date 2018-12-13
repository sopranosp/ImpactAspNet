using Loja.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace Loja.Repositorio.SqlServer.ModelConfiguration
{
    public class ClientesConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClientesConfiguration()
        {
            Property(c => c.Nome)
            .IsRequired()
            .HasMaxLength(200);

        }
    }
}