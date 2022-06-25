using SalesWebMVC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Models;

namespace SalesWebMVC.Services
{
    public class ProdutosService
    {
        private readonly SalesWebMvcContext _context;

        public ProdutosService(SalesWebMvcContext context)
        {
            _context = context;

        }

        public List<Produtos> FindAll()
        {
            return _context.Produtos.OrderBy(x => x.Descricao).ToList();
        }
    }


}
