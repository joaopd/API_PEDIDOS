using CmpPedidos.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CmpPedidos.Reposiotry
{
  public class ClienteMap : BaseDomainMap<Cliente>
  {
    public ClienteMap() : base("tb_Cliente")
    {
        
    }
    public override void Configure(EntityTypeBuilder<Cliente> builder)
    {
      
    }
  }
}
