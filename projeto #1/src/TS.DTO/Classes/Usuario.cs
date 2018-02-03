namespace TS.DTO.Classes {
    public class Usuario
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        public virtual TipoUsuario Tipo { get; set; }
        

    }
}
