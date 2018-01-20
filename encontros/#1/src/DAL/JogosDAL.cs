using DTO;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class JogosDAL
    {
        List<JogosDTO> db = new List<JogosDTO>();

        public string Insert(JogosDTO jgs)
        {
            if (jgs == null)
            {
                return "Fail";
            }
            else
            {
                db.Add(jgs);

                return "Ok";
            }
        }

        public void Update(JogosDTO jgs)
        {
            var up = db.Find(x => x.Id == jgs.Id);
        }

        public List<JogosDTO> FindAll()
        {
            return db.ToList();
        }

        public void Delete(JogosDTO jgs)
        {
            db.Remove(jgs);
        }

        public void Search(JogosDTO jgs)
        {
            db.Find(x => x.Id == jgs.Id);
        }

    }//Class

}//Namespace
