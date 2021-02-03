using CmpPedidos.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CmpPedidos.Reposiotry
{
  public class ProdutoMap : BaseDomainMap<Produto>
  {
    public ProdutoMap() : base("tb_Produto")
    {

    }
    public override void Configure(EntityTypeBuilder<Produto> builder)
    {
      base.Configure(builder);
    }
  }
}
