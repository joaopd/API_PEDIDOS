using System;
using System.Collections.Generic;

namespace CmpPedidos.Domain
{
  public class Pedido : BaseDomain
  {
    public string Numero { get; set; }
    public decimal ValorTotal { get; set; }
    public TimeSpan Entrega { get; set; }

    public int IdCliente { get; set; }
    public Cliente Cliente { get; set; }

    public virtual List<Produto> Produtos { get; set; }
  }
}
