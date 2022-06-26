using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Services;
using SalesWebMVC.Models;
using SalesWebMVC.Models.ViewModels;


namespace SalesWebMVC.Controllers
{
    public class PedidosController : Controller
    {

        private readonly PedidoService _pedidosService;
        private readonly ProdutoService _produtoService;

        public PedidosController(PedidoService pedidosService , ProdutoService produtoServices)
        {
            _pedidosService = pedidosService;
            _produtoService = produtoServices;
        }

        public IActionResult Index()
        {
            var list = _pedidosService.FindAll();
            return View(list);
        }

      public IActionResult Create ()
        {
            var produtos = _produtoService.FindAll();
            var viewModel = new PedidosFormViewModel { Produtos   = produtos  };
            return View(viewModel); 
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Pedido pedidos)
        {
            _pedidosService.Insert(pedidos);
            return Redirect(nameof(Index));
;        }


    }
}
