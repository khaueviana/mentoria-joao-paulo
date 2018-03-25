using System;

namespace TS.DTO.Classes
{
    public class Venda
    {

        public int Id { get; set; }
        public int  SessaoId { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }

        public virtual Sessao Sessao { get; set; }
    }
}
