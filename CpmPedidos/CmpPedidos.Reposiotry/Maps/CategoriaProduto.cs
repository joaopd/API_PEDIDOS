using CmpPedidos.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CmpPedidos.Reposiotry
{
  public class CategoriasProdutoMap : BaseDomainMap<CategoriasProduto>
  {
    public CategoriasProdutoMap() : base("tb_CategoriasProduto")
    {

    }
    public override void Configure(EntityTypeBuilder<CategoriasProduto> builder)
    {
      base.Configure(builder);

    }
  }
}
