using System.Collections.Generic;
using TS.DTO.Classes;

namespace TS.DAL
{
    public class FuncionarioDAL
    {
        readonly Context _context = new Context();


        public IEnumerable<Funcionario> GetAll()
        {

            return new List<Funcionario>(_context.Funcionarios);
        }

        public Funcionario GetById(int id)
        {

            var func = _context.Funcionarios.Find(id);

            return func;

        }
    }
}
