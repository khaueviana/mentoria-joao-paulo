using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TS.DTO.Classes;

namespace TS.DAL
{
    public class VendaDAL
    {

        readonly Context _context = new Context();

        public IEnumerable<Venda> GetAll()
        {

            return new List<Venda>(_context.Venda
                .Include(v => v.Sessao)
                .Include(v => v.Sessao.Cliente)
                .Include(v => v.Sessao.FormaPagamento));
        }
    }
}
