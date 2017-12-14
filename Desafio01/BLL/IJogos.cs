using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using DTO;

namespace BLL
{
    interface IJogos {

        IList Exibir();
        bool Cadastrar(JogosDTO dto);
        bool Update(JogosDTO dto);
        bool Excluir(JogosDTO dto);


    }
}
