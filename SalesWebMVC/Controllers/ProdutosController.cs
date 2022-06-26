using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Services;

namespace SalesWebMVC.Controllers
{
    public class ProdutosController : Controller
    {

        private readonly ProdutoService _produtoServices;

        public ProdutosController(ProdutoService produtosServices)
        {
            _produtoServices = produtosServices;
        }

        public IActionResult Index()
        {
            var list = _produtoServices.FindAll();
            return View(list);
        }

       
    }
}
