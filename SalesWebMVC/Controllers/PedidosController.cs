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

        private readonly PedidosService _produtosServices;

        public PedidosController(PedidosService produtosServices)
        {
            _produtosServices = produtosServices;
        }

        public IActionResult Index()
        {
            var list = _produtosServices.FindAll();
            return View(list);
        }

      public IActionResult Create ()
        {
            var produto= _produtosServices.FindAll();
           // var viewModel = new PedidosFormViewModel {  Produto = (ICollection<Produtos>) produto };
            return View(); 
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Pedidos pedidos)
        {
            _produtosServices.Insert(pedidos);
            return Redirect(nameof(Index));
;        }


    }
}
