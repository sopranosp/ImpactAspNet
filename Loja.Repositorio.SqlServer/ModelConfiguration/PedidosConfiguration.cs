using Loja.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace Loja.Repositorio.SqlServer.ModelConfiguration
{
    public class PedidosConfiguration : EntityTypeConfiguration<Pedido>
    {
        public PedidosConfiguration()
        {
            HasRequired(p => p.Cliente);
        }
    }
}