﻿using System;
using Microsoft.AspNetCore.Mvc;

namespace CmpPedidos.Api.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class PedidoController : AppBaseController
  {

    public PedidoController(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }
  }
}
