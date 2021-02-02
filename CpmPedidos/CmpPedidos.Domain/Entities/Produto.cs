using System.Collections.Generic;

namespace CmpPedidos.Domain
{
  public class Produto : BaseDomain, IExibivel
  {
    public string Nome { get; set; }
    public string Codigo { get; set; }
    public string Descricao { get; set; }
    public decimal Preco { get; set; }
    public int IdCategoria { get; set; }
    public virtual CategoriasProduto Categoria { get; set; }
    public virtual List<Imagem> Imagens { get; set; }
    public bool Ativo { get; set; }
  }
}
