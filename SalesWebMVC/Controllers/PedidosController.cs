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
        private readonly ClienteService _clientesService;

        public PedidosController(PedidoService pedidosService , ProdutoService produtoServices, ClienteService clienteService)
        {
            _pedidosService = pedidosService;
            _produtoService = produtoServices;
            _clientesService = clienteService;
        }

        public IActionResult Index()
        {
            var list = _pedidosService.FindAll();
            return View(list);
        }

      public IActionResult Create ()
        {
            var produtos = _produtoService.FindAll();
            var clientes = _clientesService.FindAll();
            var viewModel = new PedidosFormViewModel { Produtos   = produtos, Clientes = clientes  };
            return View(viewModel); 
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Pedido pedidos)
        {
            _pedidosService.Insert(pedidos);
            return Redirect(nameof(Index));
;        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _pedidosService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);

        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Index));
            }

            var obj = _pedidosService.FindById(id.Value );
            if (obj == null)
            {
                return RedirectToAction(nameof(Index));

            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _pedidosService.Remove(id);
            return RedirectToAction(nameof(Index));


        }


      

    }
}
