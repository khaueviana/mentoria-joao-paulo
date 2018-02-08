﻿using TS.DAL;
using TS.DTO.Classes;

namespace TS.BLL
{
    public class ClienteBLL
    {

        readonly Context _context = new Context();

        public void Insert(Cliente cliente)
        {
            
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
            
        }

        public void Update(Cliente cliente)
        {

            _context.Clientes.Update(cliente);
            _context.SaveChanges();
            
        }

        public void Delete(Cliente cliente)
        {
            _context.Clientes.Remove(cliente);
            _context.SaveChanges();

            
        }

        

    }
}
