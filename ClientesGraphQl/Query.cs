using ClientesGraphQl.Model;
using ClientesGraphQl.Repository;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientesGraphQl
{
    public class Query
    {
        [GraphQLName("getClientes")]
        public List<Cliente> GetClientes([Service] ClienteRepository repository) => repository.GetAll();

        [GraphQLName("getCliente")]
        public Cliente GetCliente(int id, [Service] ClienteRepository repository) => repository.GetById(id);
    }
}
