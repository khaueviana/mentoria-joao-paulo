using DAL;
using DTO;

namespace BLL
{
    public class JogosBLL
    {
        JogosDAL dal = new JogosDAL();

        public bool Cadastrar(JogosDTO dto)
        {
            dal.Insert(dto);
            return true;
        }

        public bool Excluir(JogosDTO dto)
        {
            dal.Delete(dto);
            return true;
        }


        public bool Update(JogosDTO dto)
        {
            dal.Update(dto);
            return true;
        }
    }//Class

}//Namespace
