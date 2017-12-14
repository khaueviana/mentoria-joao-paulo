using System.Collections;
using DAL;
using DTO;

namespace BLL{

    public class JogosBLL {

        //JogosDAL jgsdb = new JogosDAL();
        //JogosDTO jgsdto;
        //Construtor ou dar override no metodo da DAL?
        JogosDAL dal = new JogosDAL();

        public bool Cadastrar(JogosDTO dto) {

            dal.Insert(dto);

            return true;
        }

        public bool Excluir(JogosDTO dto) {

            dal.Delete(dto);

            return true;
        }

        //public IList Exibir() {


        //    return
        //}

        public bool Update(JogosDTO dto) {

            dal.Update(dto);

            return true;
        }
    }//Class

}//Namespace
