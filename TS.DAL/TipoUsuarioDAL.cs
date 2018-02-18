using System.Collections.Generic;
using TS.DTO.Classes;

namespace TS.DAL
{
    public class TipoUsuarioDAL
    {
        readonly Context _context = new Context();

        public IEnumerable<TipoUsuario> GetAll()
        {

            return new List<TipoUsuario>(_context.TipoUsuarios);
        }

        public TipoUsuario GetById(int id)
        {

            var tipoUsuario = _context.TipoUsuarios.Find(id);

            return tipoUsuario;

        }
    }
}
