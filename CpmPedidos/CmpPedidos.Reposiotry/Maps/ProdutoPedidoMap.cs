using CmpPedidos.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CmpPedidos.Reposiotry
{
  public class ProdutoPedidoMap : BaseDomainMap<ProdutoPedido>
  {
    public ProdutoPedidoMap() : base("tb_ProdutoPedido")
    {
        
    }
    public override void Configure(EntityTypeBuilder<ProdutoPedido> builder)
    {
      
    }
  }
}
