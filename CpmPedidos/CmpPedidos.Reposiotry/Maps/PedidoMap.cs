using CmpPedidos.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CmpPedidos.Reposiotry
{
  public class PedidoMap : BaseDomainMap<Pedido>
  {
    public PedidoMap() : base("tb_Pedido")
    {

    }
    public override void Configure(EntityTypeBuilder<Pedido> builder)
    {
      base.Configure(builder);
    }
  }
}
