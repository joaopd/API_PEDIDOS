namespace CmpPedidos.Domain
{
  public class CategoriasProduto : BaseDomain, IExibivel
  {
    public string Nome { get; set; }
    public bool Ativo { get; set; }
  }
}
