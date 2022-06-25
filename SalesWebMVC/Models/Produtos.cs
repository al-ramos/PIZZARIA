using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Models
{
    public class Produtos
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public double Valor { get; set; }

        public Produtos()
        {

        }

        public Produtos(int id, string descricao, double valor)
        {
            Id = id;
            Descricao = descricao;
            Valor = valor;
        }
    }

}
