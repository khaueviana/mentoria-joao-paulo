
using System.Collections.Generic;
using System.Linq;
using TS.DTO.Classes;

namespace TS.DAL
{
    public class ClienteDAL
    {
        readonly Context _context = new Context();

        public IEnumerable<Cliente> GetAll()
        {
            
            return new List<Cliente>(_context.Clientes);
        }

        public Cliente GetById(int id)
        {

            var query = _context.Clientes.Find(id);

            return query;

        }

    }
}
