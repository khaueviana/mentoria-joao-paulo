﻿using System.Collections.Generic;

namespace TS.DTO.Classes {
    public class TipoUsuario
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
