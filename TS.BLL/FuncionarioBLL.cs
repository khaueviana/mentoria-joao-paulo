using TS.DAL;
using TS.DTO.Classes;

namespace TS.BLL
{
    public class FuncionarioBLL
    {

        readonly Context _context = new Context();

        public void Insert(Funcionario funcionario)
        {

            _context.Funcionarios.Add(funcionario);
            _context.SaveChanges();

        }

        public void Update(Funcionario funcionario)
        {

            _context.Funcionarios.Update(funcionario);
            _context.SaveChanges();

        }

        public void Delete(int id)
        {
            Funcionario funcionario = _context.Funcionarios.Find(id);
            _context.Remove(funcionario);
            _context.SaveChanges();


        }

    }
}
