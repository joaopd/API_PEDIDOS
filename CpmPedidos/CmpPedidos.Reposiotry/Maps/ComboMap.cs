using CmpPedidos.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CmpPedidos.Reposiotry
{
  public class ComboMap : BaseDomainMap<Combo>
  {
    public ComboMap() : base("tb_Combo")
    {
        
    }
    public override void Configure(EntityTypeBuilder<Combo> builder)
    {
      
    }
  }
}
