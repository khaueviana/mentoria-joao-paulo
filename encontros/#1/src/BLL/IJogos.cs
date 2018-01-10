using System.Collections;
using DTO;

namespace BLL
{
    interface IJogos
    {
        IList Exibir();
        bool Cadastrar(JogosDTO dto);
        bool Update(JogosDTO dto);
        bool Excluir(JogosDTO dto);
    }
}