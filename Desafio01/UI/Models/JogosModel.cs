using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DTO;


namespace UI.Models
{
    public class JogosModel {

        //o que fazer nessa model? deixar assim e passar esses valores para o dto?

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string CodigoBarra { get; set; }
        public int Preco { get; set; }
        public int QuantidadeEstoque { get; set; }

            



    }
}
