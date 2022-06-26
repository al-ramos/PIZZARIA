using SalesWebMVC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Models;

namespace SalesWebMVC.Services
{
    public class ClienteService
    {
        private readonly SalesWebMvcContext _context;

        public ClienteService(SalesWebMvcContext context)
        {
            _context = context;

        }

        public List<Cliente> FindAll()
        {
            return _context.Cliente.OrderBy(x => x.Name).ToList();
        }
    }


}
