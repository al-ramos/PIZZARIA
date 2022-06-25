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

        private readonly ProdutosService _produtosServices;

        public ProdutosController(ProdutosService produtosServices)
        {
            _produtosServices = produtosServices;
        }

        public IActionResult Index()
        {
            var list = _produtosServices.FindAll();
            return View(list);
        }

       
    }
}
