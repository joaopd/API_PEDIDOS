using CmpPedidos.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CmpPedidos.Reposiotry
{
  public class CidadeMap : BaseDomainMap<Cidade>
  {
    public CidadeMap() : base("tb_cidade")
    {
        
    }
    public override void Configure(EntityTypeBuilder<Cidade> builder)
    {
      
    }
  }
}
