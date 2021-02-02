using System;
using Microsoft.AspNetCore.Mvc;

namespace CmpPedidos.Api.Controllers
{
    public class AppBaseController : ControllerBase
    {

        protected readonly IServiceProvider _ServiceProvider;
        public AppBaseController(IServiceProvider serviceProvider)
        {    
            _ServiceProvider = serviceProvider;
        }
    }
}
