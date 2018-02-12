using System.Collections.Generic;
using TS.DTO.Classes;

namespace TS.DAL
{
    public class UsuarioDAL
    {
        readonly Context _context = new Context();


        public IEnumerable<Usuario> GetAll()
        {

            return new List<Usuario>(_context.Usuarios);
        }

        public Usuario GetById(int id)
        {

            var usu = _context.Usuarios.Find(id);

            return usu;

        }
    }
}
