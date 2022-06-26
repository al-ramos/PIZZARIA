using SalesWebMVC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Models;

namespace SalesWebMVC.Services
{
    public class ProdutoService
    {
        private readonly SalesWebMvcContext _context;

        public ProdutoService(SalesWebMvcContext context)
        {
            _context = context;

        }

        public List<Produto> FindAll()
        {
            return _context.Produto.OrderBy(x => x.Descricao).ToList();
        }
    }


}
