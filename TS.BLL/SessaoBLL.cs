﻿using TS.DAL;
using TS.DTO.Classes;

namespace TS.BLL
{
    public class SessaoBLL
    {

        readonly Context _context = new Context();

        public void Insert(Sessao sessao)
        {
            //sessao.ClienteId = clienteId;
            //sessao.FormaPagamentoId = formaPagamentoId;
            _context.Sessoes.Add(sessao);
            _context.SaveChanges();

        }

        public void Update(Sessao sessao)
        {
            _context.Sessoes.Update(sessao);
            _context.SaveChanges();
            
        }

        public void Delete(int id)
        {
            Sessao sessao = _context.Sessoes.Find(id);
            _context.Sessoes.Remove(sessao);
        }
    }
}
