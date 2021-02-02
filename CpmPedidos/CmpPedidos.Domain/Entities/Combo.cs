using System.Collections.Generic;

namespace CmpPedidos.Domain
{
  public class Combo : BaseDomain, IExibivel
  {
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public bool Ativo { get; set; }

    public int IdImagem { get; set; }
    public virtual Imagem Imagem { get; set; }


    public virtual List<Produto> Produtos { get; set; }

  }
}
