    class Program
    {
        public static List<Vida> listaDaVia = new List<Vida>();

        static void Main(string[] args)
        {
            //Insert
            listaDaVia.Add(new Vida { Id = 1, EhUmToddynho = false });
            listaDaVia.Add(new Vida { Id = 2, EhUmToddynho = false });
            listaDaVia.Add(new Vida { Id = 3, EhUmToddynho = false });
            listaDaVia.Add(new Vida { Id = 4, EhUmToddynho = false });

            //Update
            var vidaToUpdate = listaDaVia.Find(x => x.Id == 1);
            vidaToUpdate.EhUmToddynho = true;

            //Search
            var vidaToSearch = listaDaVia.FindAll(x => x.EhUmToddynho);

            //Delete
            listaDaVia.RemoveAll(x => x.Id == 3);
        }  
    }

    public class Vida
    {
        public long Id { get; set; }
        public bool EhUmToddynho { get; set; }
    }