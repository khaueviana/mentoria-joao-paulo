using TS.DAL;
using TS.DTO.Classes;

namespace TS.BLL
{
   public class UsuarioBLL
    {

        readonly Context _context = new Context();
        

        public void Insert(Usuario usuario, int TipoId)
        {
            usuario.TipoUsuarioId = TipoId;
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public void Update(Usuario usuario)
        {

            _context.Usuarios.Update(usuario);
            _context.SaveChanges();

        }

        public void Delete(int id)
        {
            Usuario usuario = _context.Usuarios.Find(id);
            _context.Remove(usuario);
            _context.SaveChanges();


        }
    }
}
