using CmpPedidos.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CmpPedidos.Reposiotry
{
  public class BaseDomainMap<TDomain> : IEntityTypeConfiguration<TDomain> where TDomain :BaseDomain
  {
    private readonly string _tableName;
    public BaseDomainMap(string tableName = "")
    {
      _tableName = tableName;
    }

    public virtual void Configure(EntityTypeBuilder<TDomain> builder)
    {
      if(!string.IsNullOrEmpty(_tableName))
      {
        builder.ToTable(_tableName);
      }
    }
  }
}
