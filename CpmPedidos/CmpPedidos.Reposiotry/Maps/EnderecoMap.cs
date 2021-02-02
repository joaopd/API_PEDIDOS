using CmpPedidos.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CmpPedidos.Reposiotry
{
  public class EnderecoMap : BaseDomainMap<Endereco>
  {
    public EnderecoMap() : base("tb_Endereco")
    {
        
    }
    public override void Configure(EntityTypeBuilder<Endereco> builder)
    {
      
    }
  }
}
