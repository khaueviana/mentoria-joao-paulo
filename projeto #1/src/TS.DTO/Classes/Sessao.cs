using System;

namespace TS.DTO.Classes
{
    public class Sessao
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public decimal Preco { get; set; }


        public virtual Cliente Cliente { get; set; }
        public virtual Pagamento FormaPagamento { get; set; }
    }
}
