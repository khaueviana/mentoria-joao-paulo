using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TS.DTO.Classes;

namespace TS.DAL
{
    public class SessaoDAL
    {

        readonly Context _context = new Context();

        public IEnumerable<Sessao> GetAll()
        {
            //_context.Sessoes.Include(c => c.Cliente);

            return new List<Sessao>(_context.Sessoes.Include(c => c.Cliente)
                        .Include(c => c.FormaPagamento));
        }

        public Sessao GetById(int id)
        {

            var query = _context.Sessoes.Find(id);

            return query;

        }
    }
}
