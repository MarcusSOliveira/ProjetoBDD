using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Aplicacao.Contracts
{
    public interface IAppServiceBase<T, K>
    {
        void Cadastrar(T obj);
        void Alterar(T obj);
        void Excluir(K id);
        List<T> ObterTodos();
        T ObterPorId(K id);
    }
}
