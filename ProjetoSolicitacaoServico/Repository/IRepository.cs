using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    interface IRepository <T>
    {
        bool Cadastrar(T objeto);

        T BuscarPorId(int Id);

        List<T> ListarTodos();
    }
}
