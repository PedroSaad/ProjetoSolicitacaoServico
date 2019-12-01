using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
   public class FuncionarioDAO : IRepository<Funcionario>
    {
        private readonly Context _context;

        public FuncionarioDAO(Context context)
        {
            _context = context;
        }
        public Funcionario BuscarPorId(int Id)
        {
            return _context.Funcionarios.Find(Id);
        }

        public bool Cadastrar(Funcionario f)
        {
            if (BuscarPorCpf(f) == null)
            {
                _context.Funcionarios.Add(f);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public Funcionario BuscarPorCpf(Funcionario f)
        {
            return _context.Funcionarios.FirstOrDefault
                (x => x.Cpf.Equals(f.Cpf));
        }


        public List<Funcionario> ListarTodos()
        {
            return _context.Funcionarios.ToList();

        }
    }
}
