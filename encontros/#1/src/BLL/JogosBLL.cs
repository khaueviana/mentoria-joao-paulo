using System.Collections.Generic;
using DAL;
using DTO;

namespace BLL
{
    public class JogosBLL
    {     
        JogosDAL dal = new JogosDAL();

        public bool Insert(JogosDTO dto)
        {
            dal.Insert(dto);

            return true;
        }

        public bool Delete(JogosDTO dto)
        {
            dal.Delete(dto);

            return true;
        }

        public List<JogosDTO> FindAll()
        {
            return dal.FindAll();
        }

        public bool Update(JogosDTO dto)
        {
            dal.Update(dto);

            return true;
        }
    }//Class

}//Namespace
