using SalesWebMVC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Models;

namespace SalesWebMVC.Services
{
    public class ClientesService
    {
        private readonly SalesWebMvcContext _context;

        public ClientesService(SalesWebMvcContext context)
        {
            _context = context;

        }

        public List<Clientes> FindAll()
        {
            return _context.Clientes.OrderBy(x => x.Name).ToList();
        }
    }


}
