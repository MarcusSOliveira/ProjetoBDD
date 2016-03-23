using Projeto.Aplicacao.Contracts;
using Projeto.Dominio.DomainContracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Aplicacao.Services
{
    public class AppServiceBase<T, K>
        : IAppServiceBase<T, K>
    {
        //atributo..
        private IDomainServiceBase<T, K> dominio;

        //construtor..
        public AppServiceBase(IDomainServiceBase<T, K> dominio)
        {
            this.dominio = dominio;
        }

        public void Cadastrar(T obj)
        {
            dominio.Cadastrar(obj);
        }

        public void Alterar(T obj)
        {
            dominio.Alterar(obj);
        }

        public void Excluir(K id)
        {
            dominio.Excluir(id);
        }

        public T ObterPorId(K id)
        {
            return dominio.ObterPorId(id);
        }

        public List<T> ObterTodos()
        {
            return dominio.ObterTodos();
        }
    }
}
