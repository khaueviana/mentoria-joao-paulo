using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TS.DTO.Classes;

namespace TS.DAL
{
    public class UsuarioDAL
    {
        readonly Context _context = new Context();


        public IEnumerable<Usuario> GetAll()
        {

            return new List<Usuario>(_context.Usuarios
                .Include(u => u.Tipo));
        }

        public Usuario GetById(int id)
        {

            var usu = _context.Usuarios.Find(id);

            return usu;

        }
    }
}
