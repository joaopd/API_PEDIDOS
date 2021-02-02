using CmpPedidos.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CmpPedidos.Reposiotry
{
  public class PromocaoProdutoMap : BaseDomainMap<PromocaoProduto>
  {
    public PromocaoProdutoMap() : base("tb_PromocaoProduto")
    {
        
    }
    public override void Configure(EntityTypeBuilder<PromocaoProduto> builder)
    {
      
    }
  }
}
