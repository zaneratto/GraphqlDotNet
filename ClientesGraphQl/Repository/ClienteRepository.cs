using ClientesGraphQl.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientesGraphQl.Repository
{
    public class ClienteRepository
    {
        private readonly List<Cliente> _clientes;

        public ClienteRepository()
        {
            _clientes = new List<Cliente>
             {
                 new Cliente { Id = 1, Nome = "João", Email = "joao@example.com" },
                 new Cliente { Id = 2, Nome = "Maria", Email = "maria@example.com" },
                 new Cliente { Id = 3, Nome = "Pedro", Email = "pedro@example.com" }
             };
        }

        public List<Cliente> GetAll() => _clientes;

        public Cliente GetById(int id) => _clientes.FirstOrDefault(c => c.Id == id);
    }
}
