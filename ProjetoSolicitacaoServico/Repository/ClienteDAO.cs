using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class ClienteDAO : IRepository<Cliente>
    {
        private readonly Context _context;

        public ClienteDAO(Context context)
        {
            _context = context;
        }
        public Cliente BuscarPorId(int Id)
        {
            return _context.Clientes.Find(Id);
        }

        public bool Cadastrar(Cliente c)
        {
            if (BuscarPorCnpj(c) == null)
            {
                _context.Clientes.Add(c);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public Cliente BuscarPorCnpj (Cliente c)
        {
            return _context.Clientes.FirstOrDefault
                (x=> x.Cnpj.Equals(c.Cnpj));
        }


        public List<Cliente> ListarTodos()
        {
            return _context.Clientes.ToList();

        }

    }
}
