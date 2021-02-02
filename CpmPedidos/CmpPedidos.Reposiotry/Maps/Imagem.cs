using CmpPedidos.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CmpPedidos.Reposiotry
{
  public class ImagemMap : BaseDomainMap<Imagem>
  {
    public ImagemMap() : base("tb_Imagem")
    {
        
    }
    public override void Configure(EntityTypeBuilder<Imagem> builder)
    {
      
    }
  }
}
