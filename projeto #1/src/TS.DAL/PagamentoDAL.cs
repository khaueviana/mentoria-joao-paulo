
using System.Collections.Generic;
using TS.DTO.Classes;

namespace TS.DAL
{
    public class PagamentoDAL
    {

        readonly Context _context = new Context();

        public IEnumerable<Pagamento> GetAll()
        {
            return new List<Pagamento>(_context.Pagamentos);
        }

        public Pagamento GetById(int id)
        {
            var pagamento = _context.Pagamentos.Find(id);

            return pagamento;
        }
    }
}
