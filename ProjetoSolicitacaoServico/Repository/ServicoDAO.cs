using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
   public class ServicoDAO : IRepository<Servico>
    {
        private readonly Context _context;

        public ServicoDAO(Context context)
        {
            _context = context;
        }
        public Servico BuscarPorId(int Id)
        {
            return _context.Servicos.Find(Id);
        }

        public bool Cadastrar(Servico s)
        {
            if (BuscarPorNome(s) == null)
            {
                _context.Servicos.Add(s);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public Servico BuscarPorNome(Servico s)
        {
            return _context.Servicos.FirstOrDefault
                (x => x.Nome.Equals(s.Nome));
        }


        public List<Servico> ListarTodos()
        {
            return _context.Servicos.ToList();

        }
    }
}
