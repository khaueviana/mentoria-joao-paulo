using DTO;
using System.Collections.Generic;

namespace DAL {

    public class JogosDAL{

        List<JogosDTO> db = new List<JogosDTO>();

        public string Insert(JogosDTO jgs) {
            //jgs.Id++;
            if (jgs != null) {

                db.Add(jgs);

                return "Ok";

            } else {

                return "Fail";

            }
        }

        public void Update(JogosDTO jgs) {

            var up = db.Find(x => x.Id == jgs.Id);
            


        }

        public void Delete(JogosDTO jgs) {

            db.Remove(jgs);

        }

        public void Search(JogosDTO jgs) {

            db.Find(x => x.Id == jgs.Id);
        }


    }//Class

}//Namespace
