using System;
using System.Collections.Generic;

namespace TS.DTO.Classes
{
    public class RelatorioVenda
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public decimal Total { get; set; }
        
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Sessao> Sessoes { get; set; }
    }
}
